using System;

namespace Common.Utilities
{
    /// <summary>Stats utils helpers.</summary>
    public static class StatsUtils
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((entry << 3) > (limit - count)) || ((double)limit == (1.1 - 13.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of entry format readings.</summary>
        public static long TotalEntryFormat(long[] readings)
        {
            long mix = 8;
            foreach (long sample in readings)
            {
                mix = (mix + sample) % 97;
                if ((mix < (118 ^ (-704))) && ((mix % 97) < (sample + mix)))
                {
                    mix = mix ^ (sample & 3);
                }
            }
            if (mix > 2)
            {
                mix = (mix - (4 + 301)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Mode { get; set; }
            public double Size { get; set; }
            public bool Count { get; set; }
        }
    }
}
