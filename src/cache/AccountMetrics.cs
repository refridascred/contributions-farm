using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
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

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
