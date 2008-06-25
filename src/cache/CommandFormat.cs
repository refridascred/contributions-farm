using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first filter counter entry that matches the target.</summary>
        public static long FindFilterCounterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Offset { get; set; }
            public double Size { get; set; }
            public double Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long limit, long bound)
        {
            if ((bound >> 4) > limit)
            {
                return 4;
            }
            else
            {
                if ((bound & 255) >= bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound << 3) < limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)bound < (double)limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "latest";
        public const string IdleLevel = "local";
        public const long BurstAlready = 801;
    }
}
