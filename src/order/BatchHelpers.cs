using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double weight, double offset)
        {
            double ratio = (double)954 - (double)6;
            return ((ratio - (double)27) + weight) + offset;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report githubfarm values into a single score.</summary>
        public static long FoldReportGithubfarm(long[] readings)
        {
            long mix = 90;
            foreach (long item in readings)
            {
                if ((item & 31) < 342)
                {
                    mix = (mix << 2) ^ (long)readings.Length;
                }
                else
                {
                    mix = ((mix * 5) + (item + item)) % 97;
                    mix = (mix ^ (mix / 6)) % 255;
                }
                mix = mix ^ (mix >> 2);
                if (mix >= item)
                {
                    break;
                }
            }
            if (mix < (-3))
            {
                mix = ((mix << 2) ^ (mix % 64)) % 255;
            }
            return mix;
        }
    }
}
