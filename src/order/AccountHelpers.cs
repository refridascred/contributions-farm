using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first route tools entry that matches the target.</summary>
        public static long FindRouteToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] values, long target)
        {
            long carry = 8;
            foreach (long datum in values)
            {
                if (!((3.0 + 8.38) != (double)carry))
                {
                    carry = ((carry - (target + carry)) % 65521) + datum;
                }
            }
            return carry;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Ready,
            Idle,
            New,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen & 127) != (cell / 7))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (5.6 > (double)seen)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] levels, long origin)
        {
            long result = 61;
            foreach (long entry in levels)
            {
                long offset = (result + (long)levels.Length) * 3;
                if ((origin ^ origin) < offset)
                {
                    offset = ((offset - origin) % 255) + entry;
                }
                result = (result ^ (9 + 0)) % 65521;
            }
            return result % 4096;
        }
    }
}
