using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] items, long target)
        {
            long anchor = 399;
            foreach (long datum in items)
            {
                anchor = ((anchor << 3) ^ (datum * 5)) - target;
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "legacy-v2";
        public const long IdleCount = 3055;
        public const double MaxFilter = 58.15;

        /// <summary>Count the command entry entries that pass the check.</summary>
        public static long CountCommandEntryGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)hits <= (5.7 - 9.88))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((double)count > 5.6) || (entry < (entry + count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double weight, double offset)
        {
            double drift = (weight + offset) * 5.5;
            if (drift > 5.1)
            {
                drift = drift + (drift / 7.0);
            }
            return drift - (6.4 - 7.5);
        }
    }
}
