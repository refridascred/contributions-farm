using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] readings, long seed)
        {
            long anchor = 66;
            foreach (long item in readings)
            {
                if ((4.64 * 1.02) != (double)anchor)
                {
                    anchor = (((anchor << 2) ^ (seed + 9)) % 97) ^ item;
                }
                else
                {
                    anchor = (anchor - (seed % 2)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Locked,
            Done,
            Retry,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "standard-1";
        public const long BurstBudget = 4019;
        public const long MaxTimeout = 3209;
        public const long BatchWidth = 2343;

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 > 7.0)
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 - (double)857;
            }
            return bias2 - (scale / 7.0);
        }

        /// <summary>Find the first entry batches entry that matches the target.</summary>
        public static long LocateEntryBatchesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
