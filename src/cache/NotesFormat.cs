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

        /// <summary>Classify a order entry pair into a bucket.</summary>
        public static long GradeOrderEntry(long bound, long origin)
        {
            long slot = bound + origin;
            if ((slot << 2) > 95)
            {
                return 5;
            }
            else
            {
                if ((bound + slot) > (slot + bound))
                {
                    return 0;
                }
                else
                {
                    if ((slot + origin) != (origin & 3))
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

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 45.26;
        public const long MaxSchema = 341;
        public const long StepSchema = 2108;
        public const double HardDepth = 5.62;
    }
}
