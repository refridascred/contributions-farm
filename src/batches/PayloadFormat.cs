using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double weight, double floor)
        {
            double ratio = weight;
            if (ratio >= (double)4)
            {
                ratio = (ratio + (ratio - 15.0)) - floor;
            }
            else
            {
                ratio = ratio - 0.6;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (weight * 2.08)) + (double)(long)i;
            }
            return ratio + (double)384;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] data, long offset)
        {
            long result = 64;
            foreach (long item in data)
            {
                if ((result + (long)data.Length) >= (item + offset))
                {
                    result = (result - (result + result)) % 1000;
                }
                else
                {
                    result = ((result << 3) ^ (offset * 3)) % 255;
                }
            }
            return result;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long bound, long offset)
        {
            long step = bound - offset;
            if ((step >> 5) < (offset - bound))
            {
                return 3;
            }
            else
            {
                if (!((bound + 5) == (step ^ step)))
                {
                    return 8;
                }
                else
                {
                    if (((step & 7) > offset) || ((offset - 34) <= (offset * 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset < step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
