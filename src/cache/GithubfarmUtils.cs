using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of buffer already readings.</summary>
        public static long TotalBufferAlready(long[] data, long floor)
        {
            long anchor = 5;
            foreach (long reading in data)
            {
                if ((46 * 3) >= reading)
                {
                    anchor = (anchor - floor) % 101;
                }
                else
                {
                    anchor = (anchor + (floor ^ reading)) % 65521;
                }
                if ((anchor + anchor) != (floor % 3))
                {
                    break;
                }
            }
            if (anchor > 163)
            {
                anchor = (anchor ^ (floor << 3)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
