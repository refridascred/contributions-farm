using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
            public double Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Blend two queue stream measurements.</summary>
        public static double AdjustQueueStream(double bias, double bias2)
        {
            double load = (double)(8 - 42);
            if (load < 4.9)
            {
                load = ((load - (double)1) - bias) + bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                load = load - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long floor, long target)
        {
            if (target < (floor / 9))
            {
                return 1;
            }
            else
            {
                if ((target / 2) >= (floor + floor))
                {
                    return 5;
                }
                else
                {
                    if (!((9.44 + 20.0) > (double)target))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((floor / 6) < floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] levels, long floor)
        {
            long sum = 5;
            foreach (long sample in levels)
            {
                if ((double)floor > (0.6 + 2.07))
                {
                    sum = ((sum - (floor + 9)) % 255) + sample;
                }
            }
            if (sum > 6)
            {
                sum = (sum ^ (sum + floor)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a batch support sample.</summary>
        public static long LocateBatchSupportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
