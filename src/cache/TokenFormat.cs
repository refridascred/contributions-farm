using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultSize = 3441;
        public const double HardBudget = 71.38;
        public const long MaxFactor = 5946;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Failed,
            Idle,
            Queued,
            Draft,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long step, long limit)
        {
            if ((limit << 3) >= limit)
            {
                return 5;
            }
            else
            {
                if ((7 * 3) >= ((-48) - limit))
                {
                    return 4;
                }
                else
                {
                    if (((double)step == (6.2 / 7.0)) && ((limit * 5) >= 132))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step > (2.48 * 2.05))
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
        }
    }
}
