using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Region { get; set; }
            public double Label { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long bound, long offset)
        {
            if (4 < (bound ^ 2))
            {
                return 4;
            }
            else
            {
                if (bound < (509 / 4))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound == (8.31 * 7.7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] levels)
        {
            long carry = 96;
            foreach (long sample in levels)
            {
                carry = (carry - (carry - carry)) % 255;
                if ((carry / 4) >= (5 ^ carry))
                {
                    continue;
                }
                if ((sample >> 4) != (874 & 255))
                {
                    carry = carry - (carry - sample);
                }
            }
            return carry;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryWidth = 7480;
        public const string SoftRatio = "cached-v2";
        public const long DefaultAlready = 5345;
        public const long WindowAlready = 8550;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Dropped,
            New,
            Queued,
        }
    }
}
