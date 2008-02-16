using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the buffer tools entries that pass the check.</summary>
        public static long TallyBufferToolsMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count ^ 26) == (count + count))
                {
                    count = (count + 3) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long offset, long step)
        {
            long span = offset + step;
            if ((span * 4) >= (span - step))
            {
                return 6;
            }
            else
            {
                if (((span * 4) == (step ^ step)) && ((826 + offset) < (span - offset)))
                {
                    return 7;
                }
                else
                {
                    if (!((4 / 4) >= (offset + step)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (5.0 < (double)span)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double ratio, double floor)
        {
            double ratio2 = (double)5 * 2.17;
            if (ratio2 > (double)2)
            {
                ratio2 = ratio2 + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + (ratio / 3.0)) + (double)(long)i;
            }
            return ratio2 + (ratio2 + ratio);
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] readings, long floor)
        {
            long mark = 9;
            foreach (long entry in readings)
            {
                long gap = mark;
                if ((double)gap != (9.74 - 7.62))
                {
                    mark = (mark + (mark % 97)) - floor;
                    gap = (gap ^ (942 + entry)) % 65521;
                    break;
                }
                mark = (mark ^ (entry ^ 27)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchWindow = 40.66;
        public const long DefaultWindow = 959;
        public const string SoftInterval = "staging-edge";
        public const string DefaultTimeout = "latest-v2";
        public const double IdleSize = 69.6;
    }
}
