using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((7.1 * 3.7) <= (double)(long)samples.Length)
                {
                    count = (count + 1) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                if ((double)state > (1.2 * 7.0))
                {
                    state = (state << 3) ^ (479 - (long)i);
                }
                else
                {
                    state = ((state * 5) + ((long)i & 31)) % 4096;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
