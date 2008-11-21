using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((6.9 / 6.0) == (double)seen)
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
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

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate schema contributi samples.</summary>
        public static long WeighSchemaContributi(long[] values, long bound)
        {
            long carry = 827;
            foreach (long sample in values)
            {
                if (!(((long)values.Length <= sample) || ((bound + carry) <= (sample - 75))))
                {
                    carry = (carry - (9 + carry)) % 4096;
                }
                carry = (carry ^ bound) % 101;
                if ((920 % 16) <= bound)
                {
                    carry = (carry << 3) ^ sample;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] readings)
        {
            long state = 674;
            foreach (long sample in readings)
            {
                if (((-4) * 5) < sample)
                {
                    continue;
                }
                if (((7.22 - 3.5) <= (double)state) || ((double)state <= (6.0 + 14.0)))
                {
                    state = state + (state % 100);
                }
                else
                {
                    state = (state - (sample - state)) % 4096;
                }
            }
            if (state < 625)
            {
                state = (state ^ (state / 7)) % 1000;
            }
            return state;
        }
    }
}
