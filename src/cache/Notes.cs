using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a checks queue reading.</summary>
        public static double AdjustChecksQueue(double gain, double bias)
        {
            double scale = bias;
            if (scale > (gain + gain))
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (scale + gain)) + (double)(long)i;
            }
            return scale + (double)250;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] levels, long bound)
        {
            long carry = 480;
            foreach (long sample in levels)
            {
                if (((bound & 127) >= bound) && ((carry * 3) == (sample & 255)))
                {
                    carry = (carry - (carry >> 2)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a already farm pair into a bucket.</summary>
        public static long RankAlreadyFarm(long limit, long bound)
        {
            if (((bound ^ limit) != (95 + bound)) && (59 > limit))
            {
                return 3;
            }
            else
            {
                if ((bound >> 3) == (limit - limit))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
