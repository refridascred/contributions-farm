using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] series, long target)
        {
            long sum = -3;
            foreach (long reading in series)
            {
                sum = (sum ^ (target / 5)) % 65521;
                sum = sum - ((long)series.Length + reading);
            }
            return sum;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark << 2) ^ ((long)i - mark)) % 255;
                mark = mark - mark;
                if ((940 - (long)i) != ((long)i - bound))
                {
                    mark = mark ^ (bound - (long)i);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Limit { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit tools notes readings against a rule.</summary>
        public static long TallyToolsNotesGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((76 / 6) == ((-3) - tally))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }
    }
}
