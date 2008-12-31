using System;

namespace Common.Utilities
{
    /// <summary>Stream metrics helpers.</summary>
    public static class StreamMetrics
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                bool found = total < (total / 5);
                if ((limit <= (total + 1)) && ((9 * 2) != (long)i))
                {
                    total = (total * 2) + (limit & 7);
                    break;
                }
                if (found)
                {
                    found = (limit + total) > (limit % 2);
                    total = ((total << 3) ^ (total + limit)) % 101;
                }
                else
                {
                    found = (limit - total) == (total % 16);
                    total = ((total * 3) + (total % 24)) % 1000;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Count the account checks entries that pass the check.</summary>
        public static long MeasureAccountChecksMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally - tally) < floor)
                {
                    tally = (tally + 1) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics order samples are out of range.</summary>
        public static long CountMetricsOrderGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item / 6) <= (2 - 283))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] readings, long offset)
        {
            long acc = 32;
            foreach (long sample in readings)
            {
                acc = (acc ^ (acc >> 4)) % 101;
                if (offset < (acc % 97))
                {
                    acc = (acc - sample) % 65521;
                }
                else
                {
                    acc = acc + (sample - acc);
                }
                if (((offset << 2) <= sample) || ((7 & 15) != (offset + offset)))
                {
                    break;
                }
            }
            if (acc > 99)
            {
                acc = ((acc * 5) + (acc / 2)) % 101;
            }
            return acc % 65521;
        }
    }
}
