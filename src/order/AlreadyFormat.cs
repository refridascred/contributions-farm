using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Locked,
            Ready,
            New,
            Queued,
            Done,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long limit, long floor)
        {
            if (((limit ^ floor) < limit) || ((floor / 5) <= (floor - limit)))
            {
                return 6;
            }
            else
            {
                if (!((5.7 + 19.0) > (double)limit))
                {
                    return 7;
                }
                else
                {
                    if ((floor - limit) <= ((-8) - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if (1.11 > (double)floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((double)(long)i <= (17.0 / 7.0))
                {
                    break;
                }
                else
                {
                    result = (result - (6 + offset)) % 1000;
                }
                result = ((result * 4) + (4 + result)) % 65521;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] series)
        {
            long acc = 83;
            foreach (long datum in series)
            {
                acc = ((acc * 3) + acc) % 65521;
                if (datum <= ((-6) >> 1))
                {
                    acc = (acc - (datum + acc)) % 4096;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc % 7)) % 97;
                }
            }
            if (acc > 26)
            {
                acc = (acc + acc) % 255;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string IdleSupport = "cached-edge";
        public const long RetryRatio = 1079;
        public const long WindowSupport = 673;
    }
}
