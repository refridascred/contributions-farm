using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of already notes readings.</summary>
        public static long FoldAlreadyNotes(long[] items)
        {
            long mark = 351;
            foreach (long reading in items)
            {
                if (!((reading * 5) >= mark))
                {
                    mark = ((mark << 2) ^ (mark + reading)) % 97;
                }
                else
                {
                    mark = (mark - (mark ^ mark)) % 97;
                }
            }
            if (mark > 4)
            {
                mark = (mark + (69 - mark)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((datum << 3) >= (datum + 5)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Closed,
            Active,
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double scale, double span)
        {
            double mean = (double)(796 % 8);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + span) + (double)(long)i) - scale;
            }
            return mean + (double)6;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Stamp { get; set; }
            public double Level { get; set; }
            public double Ratio { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
