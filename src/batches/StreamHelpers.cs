using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((double)count == (3.0 * 7.6)) || ((cell + count) < (66 - bound)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate contributi record readings against a bound.</summary>
        public static bool GuardContributiRecordRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a entry record counter forward.</summary>
        public static long SeriesEntryRecord(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((anchor / 8) <= (bound / 2))
                {
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Count { get; set; }
            public bool Score { get; set; }
            public double Total { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
