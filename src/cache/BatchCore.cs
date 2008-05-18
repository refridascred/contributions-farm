using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Label { get; set; }
            public double Total { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!(((6.28 + 8.8) == (double)sample) || ((count / 4) >= (sample & 31))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum ^ sum) % 101) ^ (long)i2;
                }
                sum = ((sum * 5) + (origin + origin)) % 101;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
