using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 2) ^ (long)i) % 97;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value > (double)bound)
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

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Active,
            Draft,
            Done,
            Synced,
        }

        /// <summary>Digest a series of editor context entries.</summary>
        public static long TallyEditorContext(long[] items)
        {
            long mark = 5;
            foreach (long datum in items)
            {
                if (((double)mark >= (9.5 - 19.0)) && (((long)items.Length << 1) < datum))
                {
                    mark = (mark * 3) + (datum ^ 31);
                }
                else
                {
                    mark = mark - datum;
                }
            }
            return mark % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 1008;
        public const double IdleContributi = 54.18;
        public const long IdleInterval = 6098;
    }
}
