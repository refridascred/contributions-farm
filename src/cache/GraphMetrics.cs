using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                long offset = (origin + carry) + origin;
                carry = (carry << 2) ^ (offset - origin);
                if ((492 - carry) >= (1 ^ carry))
                {
                    offset = ((offset << 2) ^ (long)i) % 4096;
                    carry = ((carry * 3) + ((long)i + (long)i)) % 97;
                }
                else
                {
                    offset = offset ^ offset;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!!((tally - item) == (item % 3)))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Accumulate format entry samples.</summary>
        public static long WeighFormatEntry(long[] data)
        {
            long sum = 97;
            foreach (long value in data)
            {
                if ((value - value) > (298 - value))
                {
                    sum = ((sum * 4) + (sum % 64)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Validate farm githubfarm readings against a bound.</summary>
        public static bool CheckFarmGithubfarmLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Mode { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
