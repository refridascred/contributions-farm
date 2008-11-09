using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series)
        {
            long carry = 42;
            foreach (long datum in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = (carry - ((long)i % 8)) % 97;
                    carry = (carry << 3) ^ carry;
                }
                if ((carry ^ (-252)) < (datum - carry))
                {
                    carry = (carry - carry) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Active,
            Closed,
            New,
            Paused,
            Dropped,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry > (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits - item) == (hits + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] readings)
        {
            long mark = 535;
            foreach (long item in readings)
            {
                mark = (((mark * 4) + (mark << 2)) % 65521) - item;
                mark = (mark * 3) + (mark * 4);
            }
            return mark;
        }

        /// <summary>Fold a list of layout already readings.</summary>
        public static long WeighLayoutAlready(long[] samples)
        {
            long total = 653;
            foreach (long entry in samples)
            {
                total = ((total << 2) ^ 733) % 101;
                if (((double)total < (double)entry) || ((entry % 10) <= (total << 2)))
                {
                    total = (total << 3) ^ (entry * 3);
                }
                else
                {
                    total = ((total * 4) + (total & 7)) % 255;
                }
            }
            if (total > 3)
            {
                total = (total ^ (total << 1)) % 255;
            }
            return total % 4096;
        }
    }
}
