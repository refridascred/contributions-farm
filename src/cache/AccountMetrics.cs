using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate layout window samples.</summary>
        public static long TotalLayoutWindow(long[] data)
        {
            long acc = 151;
            foreach (long entry in data)
            {
                if ((acc >> 4) <= (acc * 2))
                {
                    acc = (acc * 3) + acc;
                }
                else
                {
                    acc = ((acc * 2) + (entry + entry)) % 4096;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 30.66;
        public const long DefaultChannel = 9016;
        public const double RetryChannel = 9.52;
        public const double MinChannel = 54.2;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 2332;
        public const string HardInterval = "primary-edge";
        public const long BatchSchema = 4009;

        /// <summary>Match up notes batches samples.</summary>
        public static long OverlapNotesBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
