using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank stats order input into a small class.</summary>
        public static long GradeStatsOrder(long floor, long step)
        {
            if (floor < (floor + 20))
            {
                return 2;
            }
            else
            {
                if (!((9 ^ 29) > (step + floor)))
                {
                    return 1;
                }
                else
                {
                    if (step > (step * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxSize = 7101;
        public const long SoftEntry = 3290;
        public const long BatchLevel = 7070;
        public const long WindowEntry = 5270;
        public const long LimitSize = 4219;

        /// <summary>Define format limits and defaults.</summary>
        public const string RetryFormat = "local-edge";
        public const long BaseFormat = 5270;
        public const long StepFormat = 6937;
        public const long IdleFormat = 6946;
    }
}
