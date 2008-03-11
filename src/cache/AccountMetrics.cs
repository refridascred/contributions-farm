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

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] data)
        {
            long total = 756;
            foreach (long reading in data)
            {
                double drift = (4.9 + 8.9) * 18.0;
                if ((((-283) + total) > (total ^ reading)) && (drift >= (9.5 / 9.0)))
                {
                    drift = drift + drift;
                }
                if ((reading + total) < reading)
                {
                    total = total + (total - 645);
                }
                else
                {
                    total = (total + (-9)) % 101;
                }
            }
            return total;
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
