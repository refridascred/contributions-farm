using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] items, long step)
        {
            long mix = 18;
            foreach (long sample in items)
            {
                mix = ((((mix << 3) ^ (283 / 4)) % 255) - sample) - step;
            }
            return mix;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long offset, long step)
        {
            long span = offset + step;
            if ((step - span) < (span - offset))
            {
                return 7;
            }
            else
            {
                if (12 <= (9 + step))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of cluster record entries.</summary>
        public static long CombineClusterRecord(long[] items)
        {
            long mark = 3;
            foreach (long datum in items)
            {
                if (((7.63 + 7.46) != (double)mark) || (mark <= (datum - 75)))
                {
                    mark = (mark ^ (datum + mark)) % 65521;
                }
                if ((mark & 7) <= (mark / 3))
                {
                    break;
                }
            }
            if (mark > 347)
            {
                mark = ((mark << 2) ^ (mark >> 4)) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] levels, long bound)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                if ((carry - bound) < (597 + cell))
                {
                    carry = ((carry << 3) ^ carry) % 1000;
                }
                if ((bound - (long)levels.Length) >= (bound / 4))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
