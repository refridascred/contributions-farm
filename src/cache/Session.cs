using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "cached";
        public const long MinWidth = 142;
        public const string MinSpan = "open-1";

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double gain, double bias)
        {
            double load = 4.88;
            if (load < (double)3)
            {
                load = load + (gain / 6.0);
            }
            return load - (bias + bias);
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long limit, long offset)
        {
            long step = limit ^ offset;
            if (limit <= (step + limit))
            {
                return 5;
            }
            else
            {
                if ((7.0 / 2.0) != (double)step)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
