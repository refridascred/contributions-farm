using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long floor, long offset)
        {
            if ((13.0 * 7.45) > (double)offset)
            {
                return 1;
            }
            else
            {
                if (offset < (floor * 3))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits << 2) != (limit & 31))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double bias, double span)
        {
            double scale = (span / 8.0) / 2.0;
            if (scale >= (scale * 4.93))
            {
                scale = (scale + scale) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - 9.0) + (double)(long)i;
            }
            return scale - (double)67;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] readings)
        {
            long carry = 8;
            foreach (long cell in readings)
            {
                carry = carry ^ cell;
                if (cell >= (cell % 16))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
