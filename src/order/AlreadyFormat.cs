using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Rank { get; set; }
            public double Offset { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((floor - seen) <= entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRatio = 4739;
        public const long WindowFactor = 6300;
        public const long IdleRoute = 5009;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark << 3) ^ (bound ^ bound);
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank stream profile input into a small class.</summary>
        public static long GradeStreamProfile(long target, long floor)
        {
            if ((0 % 12) > floor)
            {
                return 7;
            }
            else
            {
                if (!((-931) < (target & 31)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
