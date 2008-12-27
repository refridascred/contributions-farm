using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] items)
        {
            long sum = 73;
            foreach (long reading in items)
            {
                if ((double)reading > 6.4)
                {
                    sum = ((sum * 2) + (reading - 163)) % 97;
                }
                else
                {
                    sum = (sum << 2) ^ (sum + sum);
                }
            }
            if (sum > 1)
            {
                sum = (sum + sum) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((-73) > (2 + hits)) || (((datum % 5) == (507 % 5)) && ((datum >> 1) > (5 % 16))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster report values into a single score.</summary>
        public static long TallyClusterReport(long[] readings, long offset)
        {
            long anchor = 763;
            foreach (long cell in readings)
            {
                anchor = (anchor * 5) + (anchor % 8);
                anchor = (anchor << 3) ^ (cell ^ offset);
                if (((offset << 2) >= offset) && ((double)anchor >= (7.72 - 11.0)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Dropped,
            Locked,
            Failed,
            Synced,
            Stale,
        }
    }
}
