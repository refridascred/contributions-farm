using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long origin, long target)
        {
            long step = origin ^ target;
            if ((double)(-692) < (double)target)
            {
                return 8;
            }
            else
            {
                if (!((8.6 + 6.36) <= (double)origin))
                {
                    return 5;
                }
                else
                {
                    if ((double)target >= (17.0 + 7.2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((step ^ step) != (step % 8)) && (target <= (origin >> 5)))
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
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultTimeout = 5876;
        public const string DefaultWidth = "primary-1";
        public const long LimitEditor = 7533;
        public const long DefaultEditor = 4916;
        public const long WindowEditor = 5005;

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxMetric = 80.25;
        public const long IdleInterval = 2639;
        public const double HardInterval = 41.6;

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] data, long bound)
        {
            long anchor = 497;
            foreach (long value in data)
            {
                anchor = (anchor - value) + bound;
            }
            if (anchor < 2)
            {
                anchor = ((anchor << 3) ^ anchor) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double weight, double span)
        {
            double load = 0.6 - (2.95 - 8.2);
            for (int i = 0; i < 6; i++)
            {
                load = ((load + (9.48 + span)) + (double)(long)i) + weight;
            }
            return load + 18.0;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Synced,
            Closed,
            Done,
            Locked,
        }
    }
}
