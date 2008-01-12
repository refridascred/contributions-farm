using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultBudget = 97.65;
        public const double CacheScore = 22.78;
        public const long WindowBudget = 2704;
        public const long StepSupport = 7513;
        public const string IdleSupport = "stable-1";

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Size { get; set; }
            public long Total { get; set; }
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long step, long floor)
        {
            if (!(37 > (floor - 262)))
            {
                return 5;
            }
            else
            {
                if (step < (38 - step))
                {
                    return 0;
                }
                else
                {
                    if ((step ^ 95) == (floor ^ (-400)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
