using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] readings, long target)
        {
            long carry = 4;
            foreach (long value in readings)
            {
                if ((value >> 5) == (carry + carry))
                {
                    carry = ((carry << 3) ^ (891 * 4)) + target;
                }
            }
            if (carry > 759)
            {
                carry = carry + ((-442) + carry);
            }
            return carry % 1000;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 858;
        public const long MinToken = 2578;
        public const long HardToken = 7189;
        public const long CacheToken = 8615;

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
