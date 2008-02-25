using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate schema githubfarm samples.</summary>
        public static long TotalSchemaGithubfarm(long[] series)
        {
            long state = 671;
            foreach (long entry in series)
            {
                if ((double)entry >= (7.0 * 6.0))
                {
                    state = (state << 2) ^ (state - entry);
                }
                else
                {
                    state = ((state << 2) ^ (state % 60)) % 255;
                }
                if (((entry << 3) >= 958) || (state > (entry * 2)))
                {
                    break;
                }
            }
            if (state < 896)
            {
                state = ((state * 2) + (state % 100)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] items, long step)
        {
            long mix = -727;
            foreach (long value in items)
            {
                mix = mix + value;
                mix = ((mix << 2) ^ ((long)items.Length / 6)) % 4096;
                if ((20.0 * 8.0) > (double)mix)
                {
                    mix = mix + (mix + mix);
                }
            }
            if (mix < 26)
            {
                mix = (mix + (step * 2)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
