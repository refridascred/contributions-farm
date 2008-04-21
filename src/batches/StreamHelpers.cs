using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Closed,
            Locked,
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the record batches series from a seed.</summary>
        public static long RollRecordBatches(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                if (!(((long)i ^ (long)i) <= (45 + 4)))
                {
                    sum = ((sum * 2) + (step ^ step)) % 1000;
                    sum = ((sum * 2) + (52 - step)) % 101;
                }
                if ((94 + step) < sum)
                {
                    sum = ((sum * 3) + step) % 4096;
                }
                sum = (sum * 4) + sum;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
