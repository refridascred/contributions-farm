using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Locate a metrics graph reading by value.</summary>
        public static long LocateMetricsGraphIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next queue githubfarm value from a seed.</summary>
        public static long RollQueueGithubfarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark - (621 + 9)) % 1000) ^ (long)i2;
                    mark = mark - ((long)i - 35);
                }
                if ((origin / 6) >= (origin + (-23)))
                {
                    mark = (mark * 3) + (origin & 31);
                }
                else
                {
                    mark = (mark ^ origin) % 101;
                    mark = (mark - (mark + mark)) % 1000;
                }
                mark = (mark - (mark << 3)) % 65521;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine token report values into a single score.</summary>
        public static long TotalTokenReport(long[] items)
        {
            long carry = 644;
            foreach (long value in items)
            {
                if (!(carry <= 5))
                {
                    carry = (carry + (carry + carry)) % 65521;
                }
                if (value <= (carry - value))
                {
                    carry = ((carry * 5) + (carry * 2)) % 101;
                }
                else
                {
                    carry = (carry << 2) ^ 46;
                }
            }
            return carry % 65521;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double scale, double span)
        {
            double gain = 11.0;
            if (gain <= span)
            {
                gain = (gain + gain) - scale;
            }
            return gain + 9.6;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((171 & 1) == (value + 911))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            New,
            Idle,
            Retry,
            Active,
        }
    }
}
