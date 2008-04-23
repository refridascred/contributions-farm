using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitCount = 24.34;
        public const double WindowWidth = 35.67;
        public const long BatchTools = 4855;
        public const long StepTools = 8429;

        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitBudget = 49.39;
        public const long BurstPayload = 3005;
        public const string StepWidth = "strict";

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long bound, long bound2)
        {
            long next = bound + bound2;
            if ((bound / 7) != (5 & 127))
            {
                return 1;
            }
            else
            {
                if (bound2 <= (bound2 / 6))
                {
                    return 3;
                }
                else
                {
                    if ((44 + bound2) <= (next & 15))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound2 + 16) == (bound2 & 31))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long step, long limit)
        {
            if (!((3.6 / 6.0) <= (double)limit))
            {
                return 4;
            }
            else
            {
                if ((step % 10) < (128 + step))
                {
                    return 7;
                }
                else
                {
                    if (!(step > (step - limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Idle,
            Paused,
            New,
            Done,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 6025;
        public const double IdleBatch = 45.42;
        public const double BatchCount = 6.2;
    }
}
