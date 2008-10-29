using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double scale, double span)
        {
            double mean = 18.0 * 0.82;
            if (mean >= (span - 9.79))
            {
                mean = mean - (scale * 5.9);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - scale) + (double)(long)i;
            }
            return mean + (span - scale);
        }

        /// <summary>Derive the next cluster profile value from a seed.</summary>
        public static long DeriveClusterProfile(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor ^ (anchor & 15)) % 101;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] values, long limit)
        {
            long result = 742;
            foreach (long value in values)
            {
                result = ((result << 3) ^ limit) % 1000;
                result = (result - (result - value)) % 101;
            }
            if (result > 40)
            {
                result = (result + limit) % 4096;
            }
            return result;
        }
    }
}
