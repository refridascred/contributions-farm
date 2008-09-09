using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (item >= 547)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc << 2) ^ (acc << 3)) % 255;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
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
