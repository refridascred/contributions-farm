using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of report commits readings.</summary>
        public static long FoldReportCommits(long[] samples, long step)
        {
            long mix = 932;
            foreach (long sample in samples)
            {
                if ((920 * 2) > (mix / 7))
                {
                    mix = (mix ^ (step - mix)) - sample;
                }
                else
                {
                    mix = (mix - (step & 255)) % 1000;
                }
            }
            if (mix < 16)
            {
                mix = (mix + 97) % 4096;
            }
            return mix;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the cluster profile entries that pass the check.</summary>
        public static long TallyClusterProfileMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits >> 4) < (hits + hits))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowSpan = 4070;
        public const long IdleBudget = 3889;
        public const long LimitLayout = 5044;
    }
}
