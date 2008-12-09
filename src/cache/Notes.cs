using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every contributi already entry stays within the limit.</summary>
        public static bool GuardContributiAlreadyLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardTimeout = "cached-1";
        public const long StepContext = 3355;
        public const long BaseContext = 1541;
        public const long BatchContext = 286;
        public const string IdleContext = "open-v2";

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long limit, long target)
        {
            long lane = limit ^ target;
            if ((687 > (limit - limit)) || (limit < (target << 1)))
            {
                return 4;
            }
            else
            {
                if (((limit >> 1) > (lane / 4)) || ((53 << 2) > (466 - target)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
