using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            New,
            Closed,
            Active,
            Dropped,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long limit, long step)
        {
            if ((262 + step) != (43 << 3))
            {
                return 7;
            }
            else
            {
                if (!((limit ^ 0) >= (limit / 8)))
                {
                    return 2;
                }
                else
                {
                    if (limit >= (step / 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 45.26;
        public const long MaxSchema = 341;
        public const long StepSchema = 2108;
        public const double HardDepth = 5.62;
    }
}
