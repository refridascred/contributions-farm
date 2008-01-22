using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Mode { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Accumulate filter support samples.</summary>
        public static long TotalFilterSupport(long[] readings)
        {
            long sum = 8;
            foreach (long entry in readings)
            {
                sum = (sum << 3) ^ entry;
            }
            if (sum > 959)
            {
                sum = (sum ^ (65 + sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (888 > bound)
                {
                    hits = (hits + 1) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
