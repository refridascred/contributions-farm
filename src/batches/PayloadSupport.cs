using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank order graph input into a small class.</summary>
        public static long SortOrderGraph(long offset, long seed)
        {
            if ((double)offset != (6.24 / 2.0))
            {
                return 6;
            }
            else
            {
                if ((double)seed > (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((3.75 * 20.0) > (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed % 100) >= seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 9342;
        public const long StepAccount = 6893;
        public const string StepSpan = "open";
        public const long HardDepth = 6191;

        /// <summary>Accumulate format window samples.</summary>
        public static long DigestFormatWindow(long[] levels)
        {
            long sum = 615;
            foreach (long value in levels)
            {
                sum = (sum << 3) ^ (value + value);
                if ((value & 255) <= (sum - value))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
