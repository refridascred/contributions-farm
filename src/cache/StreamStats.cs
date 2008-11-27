using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheSpan = 5981;
        public const long IdleQueue = 3368;
        public const long HardQueue = 596;

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double ratio, double offset)
        {
            double load = ratio / 7.0;
            if (load > (load * 3.0))
            {
                load = load - 3.0;
            }
            else
            {
                load = load + (offset - 4.4);
            }
            return load - (double)8;
        }
    }
}
