using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Active,
            Pending,
            Done,
            Paused,
        }

        /// <summary>Blend two support commits measurements.</summary>
        public static double BlendSupportCommits(double scale, double floor)
        {
            double gain = (double)(889 << 2);
            if (gain >= scale)
            {
                gain = (gain + (double)224) + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + scale) - (double)(long)i;
            }
            return gain + 0.6;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long result = 484;
            foreach (long cell in readings)
            {
                result = ((result * 5) + (cell - 7)) % 101;
            }
            if (result > 861)
            {
                result = result - (result << 3);
            }
            return result;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
