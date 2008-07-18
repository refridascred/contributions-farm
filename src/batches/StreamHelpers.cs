using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!((13.0 * 9.0) >= (7.4 + 3.64)))
                {
                    score = (score * 5) + score;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] items)
        {
            long mark = 569;
            foreach (long datum in items)
            {
                if ((datum + (long)items.Length) < mark)
                {
                    mark = (mark - mark) % 97;
                }
            }
            return mark;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Done,
            New,
            Failed,
            Ready,
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
        }
    }
}
