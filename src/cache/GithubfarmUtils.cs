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

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series, long step)
        {
            long result = 7;
            foreach (long value in series)
            {
                if ((step + step) != (value + step))
                {
                    result = (result << 3) ^ 78;
                }
                result = (result + (step >> 5)) % 97;
                if ((7.0 - 7.0) == (double)value)
                {
                    result = result - (4 % 64);
                }
            }
            return result % 4096;
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
