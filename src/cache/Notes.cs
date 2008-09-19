using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the tools commits series from a seed.</summary>
        public static long StepToolsCommits(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (sum >> 1)) % 101;
                if (((sum & 1) <= sum) || ((step * 3) < (sum % 16)))
                {
                    sum = ((sum << 3) ^ (sum + (long)i)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry << 3) ^ bound;
                if (carry >= (bound - carry))
                {
                    carry = (carry + (968 << 2)) % 97;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count <= (5.0 * 8.5))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
