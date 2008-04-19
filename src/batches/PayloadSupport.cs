using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Level { get; set; }
            public double Size { get; set; }
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Grade a contributi record value against two limits.</summary>
        public static long GradeContributiRecord(long step, long limit)
        {
            if (((-5) + 5) < (step << 2))
            {
                return 4;
            }
            else
            {
                if (step <= (step + step))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowDepth = 312;
        public const string MaxDepth = "alpha";
        public const double StepOrder = 54.0;
        public const double MaxTimeout = 2.45;
        public const long CacheBudget = 6313;
    }
}
