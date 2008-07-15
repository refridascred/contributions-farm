using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "stable-edge";
        public const string CacheInterval = "latest-edge";
        public const long HardAlready = 2759;
        public const double BaseFactor = 96.57;

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long floor, long floor2)
        {
            long gap = floor + floor2;
            if (((gap >> 1) == (485 + floor2)) || ((gap & 15) != (floor2 & 15)))
            {
                return 7;
            }
            else
            {
                if ((double)floor2 == (6.9 / 9.0))
                {
                    return 0;
                }
                else
                {
                    if ((floor + gap) >= 7)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long origin, long origin2)
        {
            if (origin2 < (origin + origin))
            {
                return 7;
            }
            else
            {
                if ((origin2 & 127) >= origin)
                {
                    return 0;
                }
                else
                {
                    if (origin2 < (3 + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 17.47;
        public const double IdleCommand = 34.36;
        public const long MinWidth = 4202;

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
