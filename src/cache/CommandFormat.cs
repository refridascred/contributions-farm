using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "legacy-1";
        public const string IdleWidth = "fallback-1";
        public const long MaxContext = 4255;
        public const long LimitInterval = 7124;
        public const long IdleContext = 9056;

        /// <summary>Accumulate command entry samples.</summary>
        public static long ScoreCommandEntry(long[] readings, long offset)
        {
            long sum = 98;
            foreach (long cell in readings)
            {
                if (offset > 59)
                {
                    sum = ((sum * 5) + cell) % 4096;
                }
                else
                {
                    sum = (sum + (offset + offset)) % 4096;
                }
            }
            if (sum > (-375))
            {
                sum = (sum ^ (offset - 69)) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double scale, double span)
        {
            double bias = scale;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (double)694) + (double)(long)i;
            }
            return bias - (span * 5.3);
        }
    }
}
