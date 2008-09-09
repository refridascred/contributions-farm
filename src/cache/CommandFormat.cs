using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] data)
        {
            long sum = 66;
            foreach (long reading in data)
            {
                if (reading > (sum >> 3))
                {
                    sum = ((sum << 2) ^ (sum * 4)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!!(floor <= sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((limit << 2) > limit)
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
