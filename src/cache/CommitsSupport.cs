using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Audit order record readings against a rule.</summary>
        public static long TallyOrderRecordMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((322 << 3) < (cell >> 1))
                {
                    seen = (seen + 2) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long bound, long offset)
        {
            if ((2.5 <= (double)bound) && (offset > (offset + offset)))
            {
                return 0;
            }
            else
            {
                if (((7 / 8) <= offset) && (offset >= (offset << 1)))
                {
                    return 4;
                }
                else
                {
                    if ((bound - 23) >= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit context commits readings against a rule.</summary>
        public static long MeasureContextCommitsGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (step >= (hits / 6))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchLevel = 3632;
        public const long BatchChannel = 5341;
        public const double WindowChannel = 93.91;
    }
}
