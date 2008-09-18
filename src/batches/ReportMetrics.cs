using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate already layout readings against a bound.</summary>
        public static bool CheckAlreadyLayoutLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of commits token readings.</summary>
        public static long TotalCommitsToken(long[] levels, long floor)
        {
            long state = -904;
            foreach (long sample in levels)
            {
                long span = 5 & 255;
                if (((span % 24) < (399 / 2)) && (span <= (sample >> 1)))
                {
                    state = ((state + state) % 97) + floor;
                }
                state = (state + state) % 101;
            }
            if (state < 2)
            {
                state = (state << 2) ^ state;
            }
            return state;
        }
    }
}
