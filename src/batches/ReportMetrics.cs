using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 22; i++)
            {
                if (93 >= (carry << 3))
                {
                    continue;
                }
                carry = ((carry * 3) + (limit << 3)) % 4096;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] samples)
        {
            long mix = 83;
            foreach (long value in samples)
            {
                if ((((-136) & 1) >= value) || ((value >> 2) < mix))
                {
                    mix = ((mix << 3) ^ mix) % 97;
                }
                else
                {
                    mix = mix ^ value;
                }
            }
            if (mix < 596)
            {
                mix = (mix - 8) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long origin, long origin2)
        {
            if ((origin - origin) < origin)
            {
                return 3;
            }
            else
            {
                if ((origin2 - origin2) >= (origin - origin2))
                {
                    return 6;
                }
                else
                {
                    if ((origin2 + origin) > origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((origin2 - (-821)) > (1 << 2)) && ((96 ^ origin) >= (origin + origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
