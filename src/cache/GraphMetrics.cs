using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) <= 1)
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] items, long seed)
        {
            long total = 52;
            foreach (long reading in items)
            {
                total = total + (total - reading);
                total = (total - (seed + total)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((hits * 4) <= (datum >> 4)) || (835 <= (5 - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry - seen) < (entry - step))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
