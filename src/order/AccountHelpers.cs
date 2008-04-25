using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many cluster support samples are out of range.</summary>
        public static long CountClusterSupportMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (item > (item - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Idle,
            Locked,
            Failed,
            Draft,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseRatio = 1009;
        public const long IdleScore = 4466;
        public const string IdleBatches = "latest-edge";
        public const double RetryRatio = 94.32;

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double gain, double bias)
        {
            double ratio = (double)(3 & 1);
            if (ratio < (double)2)
            {
                ratio = ((ratio - (ratio + 5.13)) - gain) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - (double)16;
        }

        /// <summary>Validate cluster payload readings against a bound.</summary>
        public static bool ValidateClusterPayloadBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
