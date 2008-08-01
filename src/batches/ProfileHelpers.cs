using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long target, long offset)
        {
            long edge = target ^ offset;
            if ((target + target) <= offset)
            {
                return 6;
            }
            else
            {
                if (edge >= (offset % 100))
                {
                    return 3;
                }
                else
                {
                    if ((double)edge >= (5.5 / 6.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset < edge) || (edge <= (target ^ (-24))))
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
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstEditor = 54.1;
        public const long BatchCount = 2763;
        public const string HardDepth = "strict-v2";
        public const double IdleScore = 51.71;

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepLevel = 43.85;
        public const long LimitSpan = 4227;
        public const long LimitDepth = 3219;
        public const double BurstBudget = 15.35;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!(((2.5 / 5.0) >= (double)matches) || ((matches - cell) <= (matches & 255))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] levels)
        {
            long state = 810;
            foreach (long cell in levels)
            {
                if ((double)state <= 5.55)
                {
                    state = (state ^ cell) % 4096;
                }
            }
            return state;
        }
    }
}
