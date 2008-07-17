using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a already checks pair into a bucket.</summary>
        public static long ClassifyAlreadyChecks(long floor, long offset)
        {
            if (!((double)offset < 9.0))
            {
                return 1;
            }
            else
            {
                if ((floor + offset) <= (floor << 1))
                {
                    return 6;
                }
                else
                {
                    if (((9.5 - 9.0) != (double)floor) && (offset >= (floor % 16)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor <= (floor >> 5)) && ((floor ^ floor) <= floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double rate, double span)
        {
            double load = rate;
            if (load <= (load * 1.0))
            {
                load = (load + rate) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + rate) - (double)(long)i;
            }
            return load - (rate * 0.99);
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] samples, long limit)
        {
            long carry = 0;
            foreach (long value in samples)
            {
                if ((double)limit != (9.25 * 3.5))
                {
                    continue;
                }
                else
                {
                    carry = ((carry * 5) + value) % 101;
                    carry = carry - (limit - limit);
                }
                carry = (carry ^ (value << 1)) % 97;
                carry = (carry ^ limit) % 65521;
            }
            if (carry < 455)
            {
                carry = carry + (carry >> 2);
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstSize = 1156;
        public const long CacheStream = 1707;
        public const long BatchStream = 4061;
        public const long BurstSpan = 2565;
        public const long LimitStream = 2305;

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstScore = 3878;
        public const string DefaultScore = "legacy-1";
        public const double MinRatio = 24.94;
        public const long LimitWidth = 206;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(value < (offset - value)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
