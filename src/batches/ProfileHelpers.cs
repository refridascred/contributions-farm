using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Queued,
            Ready,
            Active,
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
            public long Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Stale,
            New,
            Active,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long floor, long floor2)
        {
            if ((floor / 3) > floor2)
            {
                return 1;
            }
            else
            {
                if ((floor2 ^ floor) < floor)
                {
                    return 0;
                }
                else
                {
                    if ((4 + floor) != (floor % 100))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 8008;
        public const double IdleContributi = 78.33;
        public const long BatchContributi = 4502;

        /// <summary>Grade a notes stats value against two limits.</summary>
        public static long SortNotesStats(long target, long limit)
        {
            long prev = target - limit;
            if (!((limit + prev) < (92 + 798)))
            {
                return 8;
            }
            else
            {
                if (((target + target) > (target << 3)) || ((double)prev < (8.0 + 9.4)))
                {
                    return 4;
                }
                else
                {
                    if ((13.0 + 20.0) > (double)prev)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
