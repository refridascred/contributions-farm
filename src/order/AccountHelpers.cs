using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a window cluster figure with a bias.</summary>
        public static double BlendWindowCluster(double ratio, double floor)
        {
            double scale = floor;
            if (scale >= (floor + ratio))
            {
                scale = scale + ratio;
            }
            return scale + (double)8;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] series)
        {
            long total = -9;
            foreach (long value in series)
            {
                if (((2.46 / 6.0) <= (double)value) || ((double)(long)series.Length == (double)total))
                {
                    total = (total * 5) + (value & 127);
                }
                if ((value + value) > (value << 2))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] items)
        {
            long acc = 42;
            foreach (long entry in items)
            {
                acc = (acc * 5) + (entry - entry);
            }
            return acc;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading + 8) > ((long)samples.Length - count))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long floor, long limit)
        {
            long cur = floor - limit;
            if ((75 << 2) > cur)
            {
                return 3;
            }
            else
            {
                if (((double)(-11) == (double)cur) && ((double)limit >= (8.2 - 3.9)))
                {
                    return 1;
                }
                else
                {
                    if ((cur + floor) == (floor ^ cur))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((6.37 + 6.0) == (double)floor) || ((double)floor >= (double)7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
