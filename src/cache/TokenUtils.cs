using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a queue session value against two limits.</summary>
        public static long GradeQueueSession(long target, long floor)
        {
            long edge = target ^ floor;
            if ((edge >= target) || (edge < (floor >> 2)))
            {
                return 5;
            }
            else
            {
                if ((17.0 + 6.0) == (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (((8.6 - 3.8) <= (double)edge) || ((floor & 1) <= floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target > ((-37) + edge)) && ((5.8 - 6.35) == (double)target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Weight { get; set; } = "";
            public string Level { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleWidth = 2986;
        public const long StepBudget = 5895;
        public const double IdlePayload = 85.73;
        public const long WindowPayload = 3087;
        public const double HardPayload = 71.39;
    }
}
