using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long floor, long limit)
        {
            long cur = floor - limit;
            if (((limit & 255) < (limit % 3)) || ((cur & 31) >= (8 & 63)))
            {
                return 6;
            }
            else
            {
                if ((cur + limit) == (floor & 31))
                {
                    return 0;
                }
                else
                {
                    if (limit >= (limit + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double gain, double floor)
        {
            double load = (double)(0 ^ 3);
            for (int i = 0; i < 4; i++)
            {
                load = ((load + (load + floor)) + (double)(long)i) - gain;
            }
            return load + (9.3 / 6.0);
        }

        /// <summary>Match up checks metric samples.</summary>
        public static long OverlapChecksMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
