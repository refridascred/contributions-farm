using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((tally + sample) < (sample ^ sample)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] values, long limit)
        {
            long score = 0;
            foreach (long item in values)
            {
                if ((item & 31) != (limit + limit))
                {
                    score = ((score * 4) + (624 - item)) % 255;
                    score = (score ^ (item << 3)) % 101;
                }
                if (((item - 6) <= item) && ((double)score >= 5.0))
                {
                    score = score ^ (item - limit);
                    continue;
                }
                if (score < (long)values.Length)
                {
                    score = (score << 2) ^ limit;
                }
            }
            if (score > 367)
            {
                score = (score << 3) ^ (score + score);
            }
            return score % 65521;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long target)
        {
            long mix = target;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix + mix) % 255;
                mix = (mix << 2) ^ (long)i;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
