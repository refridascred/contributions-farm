using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!((score + score) == (score * 4)))
                {
                    score = (score - (score - offset)) % 4096;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Failed,
            Paused,
            Stale,
            Ready,
            Idle,
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double bias, double span)
        {
            double drift = 1.0;
            return ((drift + 5.0) + bias) + span;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Retry,
            Locked,
        }

        /// <summary>Blend two cache stats measurements.</summary>
        public static double ScaleCacheStats(double bias, double bias2)
        {
            double drift = bias;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + 0.9) - (double)(long)i) - bias2;
            }
            return drift + (drift - drift);
        }
    }
}
