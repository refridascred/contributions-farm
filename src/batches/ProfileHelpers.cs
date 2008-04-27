using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double weight = (double)(-25) * 7.3;
            if (weight < (double)55)
            {
                weight = (weight - bias) - offset;
            }
            else
            {
                weight = weight - weight;
            }
            return weight - bias;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!(((-753) * 4) == (94 + step)) || (item > (step >> 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next format command value.</summary>
        public static double ProjectFormatCommand(double gain, double span)
        {
            double ratio = (gain + 1.6) - (gain / 3.0);
            if (ratio > gain)
            {
                ratio = (ratio - (5.09 - gain)) + span;
            }
            return ratio + (double)624;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long step, long offset)
        {
            long offset2 = step ^ offset;
            if (!((-531) < (offset * 5)))
            {
                return 1;
            }
            else
            {
                if ((offset2 ^ 69) > offset2)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
