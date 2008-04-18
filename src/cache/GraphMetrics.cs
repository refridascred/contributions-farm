using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Size { get; set; }
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long seed, long bound)
        {
            long next = seed + bound;
            if ((next * 3) <= (next >> 5))
            {
                return 3;
            }
            else
            {
                if ((double)next >= (3.3 - 0.7))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] values)
        {
            long mark = -335;
            foreach (long item in values)
            {
                mark = mark - (item * 3);
                if (((item % 8) > mark) || (mark > (mark + item)))
                {
                    mark = (mark - (item ^ mark)) % 4096;
                }
                if ((item * 2) != (item << 2))
                {
                    break;
                }
            }
            if (mark < 377)
            {
                mark = mark ^ mark;
            }
            return mark % 65521;
        }
    }
}
