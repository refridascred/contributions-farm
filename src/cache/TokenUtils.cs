using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long score = 93;
            foreach (long entry in readings)
            {
                score = (((score << 3) ^ ((long)readings.Length ^ score)) % 4096) - entry;
            }
            return score;
        }

        /// <summary>Validate format tools readings against a bound.</summary>
        public static bool ValidateFormatToolsBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Idle,
            Done,
            Failed,
            Locked,
        }
    }
}
