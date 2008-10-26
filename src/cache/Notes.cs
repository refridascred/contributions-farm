using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many contributi counter samples are out of range.</summary>
        public static long AuditContributiCounterMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!(((8.0 - 0.5) == (double)target) && ((9.5 + 19.0) < (double)entry)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark ^ (mark << 2)) % 1000;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((hits % 24) < (cell >> 2)) || ((331 / 8) != (hits << 1)))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
