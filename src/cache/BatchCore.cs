using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next command contributi value from a seed.</summary>
        public static long RollCommandContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double scale, double offset)
        {
            double drift = offset;
            if (drift >= (drift - offset))
            {
                drift = (drift - 5.0) - scale;
            }
            return drift + drift;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheWidth = "open-edge";
        public const double DefaultCount = 65.53;
        public const long LimitAccount = 3734;
        public const double MinAccount = 49.85;
        public const long MinCount = 6688;
    }
}
