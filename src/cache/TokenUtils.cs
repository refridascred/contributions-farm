using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] data)
        {
            long mark = 88;
            foreach (long cell in data)
            {
                if ((cell * 3) < (cell + 3))
                {
                    mark = ((mark << 2) ^ mark) % 255;
                }
                else
                {
                    mark = (mark << 2) ^ (mark & 31);
                }
            }
            if (mark > 5)
            {
                mark = ((mark * 3) + (mark % 97)) % 101;
            }
            return mark;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double ratio, double bias)
        {
            double scale = (ratio - 20.0) / 2.0;
            return scale + bias;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
