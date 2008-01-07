using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] data)
        {
            long carry = 9;
            foreach (long item in data)
            {
                if (!((item > (carry + 1)) && ((carry - item) >= item)))
                {
                    carry = carry - (carry + carry);
                }
                if (((-9) + item) < (carry + carry))
                {
                    carry = (carry + (item + item)) % 4096;
                }
                else
                {
                    carry = ((carry << 3) ^ item) % 4096;
                }
            }
            if (carry < 46)
            {
                carry = ((carry * 2) + 941) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 9195;
        public const double MaxBudget = 22.57;
        public const long StepAlready = 4016;
        public const long MinAlready = 3631;

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
