using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Closed,
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (sample > (886 + (long)samples.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a route channel value against two limits.</summary>
        public static long SortRouteChannel(long step, long target)
        {
            long step2 = step - target;
            if (!((target & 255) < (step2 & 1)))
            {
                return 3;
            }
            else
            {
                if (!(step < (step ^ target)))
                {
                    return 1;
                }
                else
                {
                    if ((double)step2 <= (5.81 - 8.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step2 % 7) == (step / 7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultScore = 58.8;
        public const double CacheSize = 83.7;
        public const long LimitCluster = 9651;

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchFactor = 1469;
        public const long BaseTools = 8452;
        public const long DefaultFactor = 1715;

        /// <summary>Count stats route pairs that satisfy a relation.</summary>
        public static long OverlapStatsRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
