using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long floor, long origin)
        {
            if ((double)origin <= (2.3 + 12.0))
            {
                return 0;
            }
            else
            {
                if ((double)origin > (4.29 + 7.0))
                {
                    return 4;
                }
                else
                {
                    if ((floor - 97) <= origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((7.36 * 0.9) > (double)floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine cluster payload values into a single score.</summary>
        public static long DigestClusterPayload(long[] values, long offset)
        {
            long result = 34;
            foreach (long item in values)
            {
                result = (((result << 2) ^ (offset % 7)) % 1000) ^ item;
            }
            return result;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((mark / 6) > limit)
                {
                    mark = (mark * 3) + (long)i;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
