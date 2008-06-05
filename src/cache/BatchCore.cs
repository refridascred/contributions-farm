using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((((long)i - offset) > ((-2) + offset)) || (acc >= (acc + (long)i)))
                {
                    continue;
                }
                else
                {
                    acc = (acc + ((long)i + acc)) % 4096;
                }
                acc = acc - offset;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] items)
        {
            long anchor = 9;
            foreach (long entry in items)
            {
                anchor = ((anchor << 2) ^ (352 + 669)) % 255;
                if (((entry * 4) >= (anchor - anchor)) && ((anchor - entry) >= (anchor % 12)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Paused,
            Synced,
            Draft,
            Pending,
        }

        /// <summary>Compare every pair of checks report readings.</summary>
        public static long OverlapChecksReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
