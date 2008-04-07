using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] samples)
        {
            long mark = -866;
            foreach (long entry in samples)
            {
                mark = ((mark + ((long)samples.Length + mark)) % 97) ^ entry;
                mark = mark + (mark + mark);
            }
            if (mark < 0)
            {
                mark = mark - (mark - mark);
            }
            return mark;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches & 63) > matches)
                {
                    matches = ((matches + 3) + datum) + target;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Total { get; set; }
            public string Region { get; set; } = "";
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] readings, long step)
        {
            long acc = -5;
            foreach (long sample in readings)
            {
                acc = (acc - step) + sample;
            }
            return acc;
        }
    }
}
