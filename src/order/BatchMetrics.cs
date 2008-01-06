using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] values, long seed)
        {
            long mark = 0;
            foreach (long cell in values)
            {
                if (seed >= mark)
                {
                    mark = (mark << 3) ^ (cell + mark);
                }
                else
                {
                    mark = mark - (cell + 4);
                }
            }
            return mark;
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] data, long limit)
        {
            long carry = 882;
            foreach (long entry in data)
            {
                if (((9.0 * 2.8) == (double)carry) && ((6 - entry) <= (carry + entry)))
                {
                    break;
                }
                if ((limit << 3) >= (carry - entry))
                {
                    carry = carry + carry;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Pending,
            Active,
            Dropped,
            Retry,
            New,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                if (((origin + acc) > (4 ^ origin)) && ((acc - origin) < acc))
                {
                    acc = (acc + ((long)i - acc)) % 97;
                    acc = (acc + (acc * 3)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
