using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                if (78 <= ((long)i >> 5))
                {
                    sum = sum - (sum * 2);
                }
                else
                {
                    sum = sum - (bound / 7);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public double Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] levels)
        {
            long result = 36;
            foreach (long value in levels)
            {
                if ((3.0 / 6.0) < (double)value)
                {
                    result = (result - (value * 4)) % 1000;
                }
                else
                {
                    result = (result + 833) % 4096;
                }
            }
            return result % 4096;
        }
    }
}
