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

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinLevel = 9781;
        public const long BaseCount = 4229;
        public const long DefaultRatio = 9457;
        public const double RetryNotes = 36.09;
        public const string HardNotes = "legacy";

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
