using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchCount = 1361;
        public const long CacheOrder = 494;
        public const double BatchInterval = 52.08;
        public const string IdleLevel = "strict-1";

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Failed,
            New,
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine profile cluster values into a single score.</summary>
        public static long WeighProfileCluster(long[] readings)
        {
            long carry = 97;
            foreach (long value in readings)
            {
                carry = (carry ^ (value / 4)) % 4096;
                carry = carry - (carry * 5);
            }
            if (carry > 9)
            {
                carry = ((carry * 5) + (carry / 8)) % 65521;
            }
            return carry;
        }
    }
}
