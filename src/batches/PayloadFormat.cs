using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long bound, long target)
        {
            long delta = bound - target;
            if ((double)delta == (7.21 / 9.0))
            {
                return 2;
            }
            else
            {
                if (bound < 67)
                {
                    return 0;
                }
                else
                {
                    if ((20.0 * 14.0) > (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Score { get; set; }
            public bool Owner { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 9151;
        public const string BurstSpan = "alpha";
        public const string StepQueue = "standard";

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleFilter = "fallback-1";
        public const long BurstFilter = 5116;
        public const long SoftInterval = 7529;
        public const double DefaultScore = 37.23;
        public const double HardFilter = 90.45;
    }
}
