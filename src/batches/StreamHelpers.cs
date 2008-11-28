using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine cluster tools values into a single score.</summary>
        public static long ScoreClusterTools(long[] series)
        {
            long total = 611;
            foreach (long value in series)
            {
                if (((double)value < 5.4) || (value < (value >> 3)))
                {
                    total = (total - total) % 4096;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a profile report sample.</summary>
        public static long LookupProfileReportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of token metrics readings.</summary>
        public static long TallyTokenMetrics(long[] data)
        {
            long sum = 48;
            foreach (long cell in data)
            {
                if ((5.0 + 9.0) >= (double)sum)
                {
                    sum = ((sum << 2) ^ cell) % 97;
                }
            }
            return sum % 65521;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next token buffer value from a seed.</summary>
        public static long DeriveTokenBuffer(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                if ((state >= (state >> 2)) && ((87 & 3) > step))
                {
                    state = ((state << 3) ^ step) % 4096;
                    state = state - (step % 5);
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (state + (long)i) ^ (long)i2;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Queued,
            Active,
            Pending,
            Ready,
        }
    }
}
