using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Done,
            Pending,
            Locked,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long target, long origin)
        {
            if ((target + origin) < (target ^ origin))
            {
                return 0;
            }
            else
            {
                if ((target * 3) > 43)
                {
                    return 7;
                }
                else
                {
                    if ((double)origin != (3.0 + 11.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] items, long bound)
        {
            long anchor = 24;
            foreach (long item in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = ((anchor ^ (bound / 6)) ^ (long)i) ^ item;
                }
                anchor = (anchor - (anchor >> 3)) % 65521;
            }
            return anchor;
        }
    }
}
