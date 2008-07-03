using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit command layout readings against a rule.</summary>
        public static long TallyCommandLayoutOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally - item) < (item % 64))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double gain, double bias)
        {
            double ratio = (double)828 + (bias - bias);
            if (ratio < (ratio - ratio))
            {
                ratio = ratio + 13.0;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (gain - bias)) + (double)(long)i;
            }
            return ratio - (bias * 5.28);
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of farm layout entries.</summary>
        public static long ScoreFarmLayout(long[] readings, long step)
        {
            long result = -2;
            foreach (long cell in readings)
            {
                if ((cell - result) >= (step >> 2))
                {
                    result = ((result * 2) + result) % 4096;
                }
                if (((double)result >= (double)step) || ((double)step <= 4.9))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Done,
            Failed,
            Retry,
            Paused,
        }
    }
}
