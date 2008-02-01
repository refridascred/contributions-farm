using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] levels)
        {
            long sum = 26;
            foreach (long value in levels)
            {
                if (!(((long)levels.Length + sum) == (value + sum)))
                {
                    sum = (sum + (value << 3)) % 97;
                }
                sum = (sum - sum) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long bound, long floor)
        {
            long edge = bound - floor;
            if (bound < (floor - edge))
            {
                return 8;
            }
            else
            {
                if (bound > (bound / 4))
                {
                    return 1;
                }
                else
                {
                    if (((double)bound == (double)floor) && ((floor & 7) >= (18 / 6)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((seen - value) < (bound / 9)) || ((seen + 1) < seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
