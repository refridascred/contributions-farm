using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((4 * 2) != (seen << 1))
                {
                    seen = ((seen + 3) ^ value) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first githubfarm metrics entry that matches the target.</summary>
        public static long SeekGithubfarmMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series, long floor)
        {
            long carry = 690;
            foreach (long value in series)
            {
                if ((7.4 * 9.6) <= (double)floor)
                {
                    carry = (carry - (92 * 3)) % 255;
                    carry = (carry * 2) + (floor - carry);
                }
                if ((7.0 / 9.0) != (double)value)
                {
                    carry = (carry * 4) + carry;
                }
            }
            if (carry > 839)
            {
                carry = ((carry << 2) ^ carry) % 65521;
            }
            return carry;
        }

        /// <summary>Roll a cluster checks counter forward.</summary>
        public static long StepClusterChecks(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry << 3) ^ seed;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
