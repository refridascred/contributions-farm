using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 4963;
        public const double BatchAlready = 13.84;
        public const long IdleAlready = 3663;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long limit, long limit2)
        {
            if (!(limit <= (limit - limit)))
            {
                return 0;
            }
            else
            {
                if ((limit << 2) < (limit2 ^ limit))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit2 == (double)71)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((sample << 1) < (46 + sample)) && (target > (seen >> 3)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
