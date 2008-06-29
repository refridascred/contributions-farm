using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank queue channel input into a small class.</summary>
        public static long GradeQueueChannel(long target, long origin)
        {
            long lane = target ^ origin;
            if (!((double)origin >= 2.5))
            {
                return 7;
            }
            else
            {
                if ((origin ^ origin) != (8 - origin))
                {
                    return 2;
                }
                else
                {
                    if (((target - 32) > (638 << 2)) && ((origin / 4) > (lane - lane)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((lane / 4) <= (origin >> 1))
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
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double rate, double span)
        {
            double bias = (double)65 / 3.0;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias - bias) + (double)(long)i) + span;
            }
            return bias + rate;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxMetric = 3.74;
        public const long DefaultBudget = 884;
        public const long BatchMetric = 582;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Done,
            New,
            Locked,
        }
    }
}
