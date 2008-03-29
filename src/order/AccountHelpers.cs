using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Weight { get; set; }
            public double Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double rate, double floor)
        {
            double mean = rate;
            if (mean < (double)66)
            {
                mean = (mean - (double)(-437)) + floor;
            }
            return mean + (double)5;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long floor, long bound)
        {
            long diff = floor + bound;
            if (((15.0 + 14.0) <= (double)floor) || ((6 - bound) == (diff - diff)))
            {
                return 2;
            }
            else
            {
                if ((diff + bound) < diff)
                {
                    return 1;
                }
                else
                {
                    if (((floor - floor) == (4 << 3)) && ((floor << 3) == (floor / 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((2.6 < (double)diff) || ((17.0 * 8.8) <= (double)floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit already batches readings against a rule.</summary>
        public static long CountAlreadyBatchesOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((count + 510) != (count >> 5)) || !(1.0 > (double)count))
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
