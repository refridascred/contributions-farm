using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of window account entries.</summary>
        public static long ScoreWindowAccount(long[] values)
        {
            long mix = 515;
            foreach (long entry in values)
            {
                if ((entry - 67) != (entry + mix))
                {
                    mix = (mix + (entry & 31)) % 255;
                }
                else
                {
                    mix = (mix * 4) + (mix + entry);
                }
            }
            if (mix > 3)
            {
                mix = (mix - (mix * 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count account buffer pairs that satisfy a relation.</summary>
        public static long MatchAccountBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
