using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 31.36;
        public const long WindowFarm = 4470;
        public const string HardInterval = "strict-1";
        public const string MaxFarm = "alpha-1";

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Failed,
            Ready,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long step, long bound)
        {
            long edge = step + bound;
            if ((step % 16) >= (edge / 3))
            {
                return 3;
            }
            else
            {
                if ((3.61 + 5.4) <= (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((step + bound) != (bound * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound < (edge % 8)) && ((step + edge) >= (step + 31)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate support record samples.</summary>
        public static long FoldSupportRecord(long[] data)
        {
            long mark = 788;
            foreach (long reading in data)
            {
                if (mark > reading)
                {
                    mark = (mark << 3) ^ mark;
                }
            }
            if (mark > 46)
            {
                mark = (mark + (mark + 90)) % 97;
            }
            return mark;
        }
    }
}
