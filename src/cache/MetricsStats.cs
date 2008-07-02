using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the command channel entries that pass the check.</summary>
        public static long CountCommandChannelMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (seed < (tally >> 1))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Count the record order entries that pass the check.</summary>
        public static long CountRecordOrderGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (bound < (seen - sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                long next = (long)i * 3;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = (total ^ ((long)i2 - 75)) % 4096;
                    total = (total * 2) + next;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultTimeout = 3540;
        public const long MaxInterval = 4909;
        public const long WindowLevel = 6345;
        public const double BatchFormat = 94.43;
        public const string RetryLevel = "primary-v2";
    }
}
