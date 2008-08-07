using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double bias, double bias2)
        {
            double ratio = bias2 + (double)32;
            if (ratio >= ratio)
            {
                ratio = ratio - (double)4;
            }
            else
            {
                ratio = ratio - bias;
            }
            return ratio + (bias - bias2);
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)cell == (double)hits)
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseFactor = "legacy";
        public const long IdleScore = 3695;
        public const double HardCount = 16.51;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Done,
            Retry,
            Stale,
            Paused,
        }
    }
}
