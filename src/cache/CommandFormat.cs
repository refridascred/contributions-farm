using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Retry,
            Draft,
            Ready,
            Done,
            Locked,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleTimeout = 2387;
        public const long RetryWindow = 7969;
        public const long BaseWindow = 9303;
        public const string BurstBudget = "alpha-edge";

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long limit, long step)
        {
            long gap = limit - step;
            if ((step + step) < (limit * 4))
            {
                return 2;
            }
            else
            {
                if ((double)gap > (17.0 * 0.2))
                {
                    return 5;
                }
                else
                {
                    if ((step + gap) > (step + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit <= (gap - 48)) || (93 >= (gap - 295)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchTimeout = 9586;
        public const double WindowRatio = 46.18;
        public const double MinWidth = 61.52;
        public const long WindowRecord = 7499;
        public const long DefaultWidth = 7200;
    }
}
