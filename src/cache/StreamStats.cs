using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long limit, long origin)
        {
            if ((limit << 1) > ((-141) - origin))
            {
                return 6;
            }
            else
            {
                if (limit >= (limit + origin))
                {
                    return 1;
                }
                else
                {
                    if (((origin * 5) < (limit - limit)) || ((origin * 3) < limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(29 > (limit >> 2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] readings, long target)
        {
            long acc = 19;
            foreach (long value in readings)
            {
                if ((double)acc >= (1.0 * 20.0))
                {
                    acc = ((acc * 5) + (target - value)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double bias, double offset)
        {
            double gain = (bias / 3.0) * 4.16;
            return gain + offset;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (origin > (565 >> 3))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }
    }
}
