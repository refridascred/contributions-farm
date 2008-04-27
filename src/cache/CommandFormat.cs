using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Idle,
            Dropped,
            Ready,
            Failed,
            Paused,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] samples, long step)
        {
            long score = 8;
            foreach (long cell in samples)
            {
                if (score > ((-75) >> 5))
                {
                    score = (((score << 3) ^ (cell * 2)) % 65521) - step;
                }
                else
                {
                    score = (score ^ (13 << 1)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardRatio = "local-1";
        public const double BatchTimeout = 41.2;
        public const string RetryContext = "primary-edge";
        public const string MinContext = "latest-v2";
        public const string SoftContext = "cached-1";
    }
}
