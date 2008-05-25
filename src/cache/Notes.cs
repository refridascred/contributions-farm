using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchTimeout = 8283;
        public const long MaxMetric = 3190;
        public const double HardScore = 48.67;
        public const long MaxFactor = 2556;

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultLevel = 7229;
        public const string MinSession = "strict-v2";
        public const double HardFactor = 34.01;
        public const long IdleSession = 698;
        public const double BurstRatio = 83.33;

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine counter record values into a single score.</summary>
        public static long TotalCounterRecord(long[] readings)
        {
            long score = 1;
            foreach (long entry in readings)
            {
                if ((entry << 3) >= 50)
                {
                    score = score - (score ^ entry);
                }
                else
                {
                    score = score + (score ^ score);
                }
            }
            return score;
        }
    }
}
