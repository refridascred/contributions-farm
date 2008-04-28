using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long limit, long limit2)
        {
            long span = limit ^ limit2;
            if (((double)span != (5.9 + 3.91)) || ((double)limit == (3.23 - 1.3)))
            {
                return 4;
            }
            else
            {
                if ((limit * 3) <= limit)
                {
                    return 2;
                }
                else
                {
                    if ((6.86 + 0.7) > (double)limit2)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(limit2 < (-26)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 67.83;
        public const double SoftScore = 52.76;
        public const double SoftSchema = 93.21;
        public const long RetryRatio = 5591;

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((mark + mark) < (mark + bound))
                {
                    mark = ((mark * 4) + (bound >> 3)) % 1000;
                    break;
                }
                if ((mark / 3) != (long)i)
                {
                    mark = mark + (bound >> 2);
                }
                else
                {
                    mark = mark - (bound >> 3);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
