using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double weight, double bias)
        {
            double bias2 = weight;
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (bias * 1.78)) + (double)(long)i;
            }
            return bias2 - weight;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Level { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Grade a batches stream value against two limits.</summary>
        public static long BucketBatchesStream(long target, long step)
        {
            if ((target - target) > (step * 3))
            {
                return 5;
            }
            else
            {
                if ((step ^ target) == (51 << 2))
                {
                    return 0;
                }
                else
                {
                    if ((target > (step + step)) || ((target * 3) >= target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step + step) >= target)
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

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches - (long)values.Length) > (matches % 100))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }
    }
}
