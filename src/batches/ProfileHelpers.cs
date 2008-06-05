using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] levels)
        {
            long mark = 408;
            foreach (long sample in levels)
            {
                if ((mark + 782) == (sample >> 4))
                {
                    mark = ((mark * 4) + (44 + (long)levels.Length)) % 255;
                }
                else
                {
                    mark = ((mark * 4) + mark) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            Stale,
            Done,
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitTimeout = 39.28;
        public const long HardSpan = 387;
        public const double BaseTimeout = 13.09;
        public const double StepDepth = 72.81;

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] samples)
        {
            long mix = 1;
            foreach (long cell in samples)
            {
                mix = mix ^ 7;
                mix = (mix << 3) ^ (cell & 7);
                if ((38 & 7) != (mix - mix))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
