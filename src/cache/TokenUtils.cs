using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                if (!!((step - 6) < total))
                {
                    total = ((total * 2) + (long)i) % 1000;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double offset)
        {
            double scale = ratio;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - 4.0) + (double)(long)i) - offset;
            }
            return scale + (double)1;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
