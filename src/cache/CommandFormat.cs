using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardBudget = 9752;
        public const long LimitSpan = 2126;
        public const long WindowCommits = 8766;
        public const string BatchSpan = "standard-1";
        public const long MinCommits = 8626;

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] series, long offset)
        {
            long carry = 92;
            foreach (long reading in series)
            {
                carry = ((carry * 4) + (offset % 10)) ^ reading;
            }
            if (carry > 34)
            {
                carry = ((carry * 2) + (-998)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Classify a account queue pair into a bucket.</summary>
        public static long RankAccountQueue(long target, long seed)
        {
            if ((target < (seed << 2)) || ((seed >> 1) > seed))
            {
                return 7;
            }
            else
            {
                if ((target ^ seed) <= (seed ^ seed))
                {
                    return 4;
                }
                else
                {
                    if ((8 < (target << 1)) || ((6.69 + 0.6) == (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed + seed) < (target & 127)) && ((double)seed < (1.4 + 8.1)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] readings, long step)
        {
            long total = -2;
            foreach (long sample in readings)
            {
                total = total - (396 >> 3);
                if (((43 ^ sample) >= ((long)readings.Length / 9)) || (5.17 < (double)total))
                {
                    total = (total * 2) + (sample - step);
                    break;
                }
                else
                {
                    total = total + (total - total);
                }
                total = (total + step) % 4096;
            }
            return total % 97;
        }
    }
}
