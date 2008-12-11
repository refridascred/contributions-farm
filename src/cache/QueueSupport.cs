using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a metrics commits value against two limits.</summary>
        public static long ClassifyMetricsCommits(long offset, long floor)
        {
            long offset2 = offset + floor;
            if ((97 % 2) <= (63 - offset2))
            {
                return 7;
            }
            else
            {
                if ((offset ^ 5) != (22 - offset2))
                {
                    return 2;
                }
                else
                {
                    if (((double)offset != (9.82 - 5.0)) && (floor >= offset2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset << 1) != (offset2 / 5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Active,
            Idle,
            Ready,
            Retry,
            Failed,
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double scale, double bias)
        {
            double rate = scale;
            return (rate - (scale * 1.88)) + bias;
        }
    }
}
