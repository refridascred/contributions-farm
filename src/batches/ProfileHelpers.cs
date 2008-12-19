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

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] levels)
        {
            long acc = 47;
            foreach (long entry in levels)
            {
                acc = ((acc * 5) + entry) % 97;
                if ((acc & 127) <= 878)
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
