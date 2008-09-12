using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Label { get; set; }
            public double Offset { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long bound, long limit)
        {
            long diff = bound + limit;
            if ((limit * 3) != (bound - bound))
            {
                return 3;
            }
            else
            {
                if ((2.0 * 1.75) > (double)diff)
                {
                    return 8;
                }
                else
                {
                    if (((8.8 + 15.0) >= (double)bound) || ((2 & 7) >= (bound - (-65))))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((diff / 7) <= bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double weight, double span)
        {
            double ratio = (double)(481 % 100);
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)(long)i) - span;
            }
            return ratio + (weight - ratio);
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Failed,
            Closed,
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long limit, long bound)
        {
            if (bound < (limit + limit))
            {
                return 8;
            }
            else
            {
                if ((limit + limit) == (bound << 2))
                {
                    return 6;
                }
                else
                {
                    if (((8.0 - 13.0) == (double)limit) || (bound <= (limit + 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + 19) >= (limit * 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
