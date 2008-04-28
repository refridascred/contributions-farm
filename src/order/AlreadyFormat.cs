using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((result + origin) > (origin & 255))
                {
                    result = ((result << 3) ^ ((long)i >> 5)) % 65521;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
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

        /// <summary>Accumulate batches stats samples.</summary>
        public static long DigestBatchesStats(long[] values)
        {
            long sum = 2;
            foreach (long datum in values)
            {
                if (((sum - datum) <= (datum / 5)) && ((sum & 1) >= (long)values.Length))
                {
                    sum = (sum + (sum << 3)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 67.83;
        public const double SoftScore = 52.76;
        public const double SoftSchema = 93.21;
        public const long RetryRatio = 5591;

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
