using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long offset)
        {
            long slot = limit + offset;
            if ((0.2 + 14.0) > (double)slot)
            {
                return 5;
            }
            else
            {
                if ((limit + limit) >= limit)
                {
                    return 0;
                }
                else
                {
                    if ((double)slot > (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset * 2) > (offset ^ slot))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first payload contributi entry that matches the target.</summary>
        public static long SeekPayloadContributiIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] samples)
        {
            long carry = 7;
            foreach (long cell in samples)
            {
                if ((carry + carry) < (cell ^ carry))
                {
                    carry = (carry ^ (cell << 1)) % 97;
                }
                else
                {
                    carry = ((carry * 5) + (carry << 2)) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxLevel = 2426;
        public const long HardLevel = 2829;
        public const long HardDepth = 7749;
        public const string RetryBudget = "open-v2";
    }
}
