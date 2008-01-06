using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitInterval = 2041;
        public const long StepAccount = 3866;
        public const long BurstScore = 7292;

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
