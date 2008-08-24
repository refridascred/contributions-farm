using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Ready,
            Closed,
            Synced,
            Queued,
        }

        /// <summary>Combine notes counter values into a single score.</summary>
        public static long TotalNotesCounter(long[] readings, long seed)
        {
            long sum = 429;
            foreach (long entry in readings)
            {
                if (!((entry + (long)readings.Length) >= (entry % 100)))
                {
                    sum = sum + 4;
                }
                if (((sum + sum) == (entry / 9)) || ((double)seed <= (17.0 / 2.0)))
                {
                    sum = sum - (89 - sum);
                }
                else
                {
                    sum = (sum ^ (sum / 3)) % 65521;
                }
                if ((sum ^ entry) <= (seed >> 4))
                {
                    break;
                }
            }
            if (sum < 15)
            {
                sum = (sum - sum) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] series, long origin)
        {
            long total = 2;
            foreach (long datum in series)
            {
                if (((origin + datum) == (76 - origin)) && ((datum / 6) > (69 / 9)))
                {
                    total = ((total * 5) + (total - total)) % 97;
                }
            }
            if (total > 49)
            {
                total = (total ^ (88 % 97)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter checks samples are out of range.</summary>
        public static long AuditFilterChecksHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (sample > 78)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
