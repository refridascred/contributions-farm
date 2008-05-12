using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double scale, double bias)
        {
            double bias2 = (double)(63 & 127);
            if (bias2 >= (double)134)
            {
                bias2 = (bias2 - bias) - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - bias) - (double)(long)i;
            }
            return bias2 - 9.4;
        }

        /// <summary>Count channel record pairs that satisfy a relation.</summary>
        public static long MatchChannelRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a farm editor pair into a bucket.</summary>
        public static long BucketFarmEditor(long offset, long floor)
        {
            if ((double)offset > (3.3 + 4.44))
            {
                return 8;
            }
            else
            {
                if (!(8.9 >= (double)floor))
                {
                    return 0;
                }
                else
                {
                    if ((357 / 4) != (offset + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((29 & 1) == (floor + offset)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
