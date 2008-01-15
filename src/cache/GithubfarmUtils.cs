using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((double)carry < (1.1 + 12.0))
                {
                    carry = (carry << 2) ^ (-99);
                }
                else
                {
                    carry = ((carry * 4) + (carry - limit)) % 65521;
                }
                carry = carry + (carry >> 5);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
