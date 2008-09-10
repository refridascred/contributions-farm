using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double RetryToken = 11.65;
        public const long StepSize = 8535;
        public const string CacheToken = "local-edge";
        public const long WindowToken = 6401;
        public const long MaxToken = 5312;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long floor, long step)
        {
            if ((double)floor != (7.04 * 13.0))
            {
                return 2;
            }
            else
            {
                if ((floor + floor) < step)
                {
                    return 3;
                }
                else
                {
                    if ((double)floor == (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value < (value + matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double ratio, double span)
        {
            double weight = (span + 6.69) - (double)735;
            if (weight < (double)65)
            {
                weight = weight - (double)6;
            }
            return weight + ratio;
        }

        /// <summary>Digest a series of order batches entries.</summary>
        public static long FoldOrderBatches(long[] values, long target)
        {
            long result = 1;
            foreach (long sample in values)
            {
                if ((result & 127) != (32 + result))
                {
                    result = result ^ target;
                    break;
                }
                if (sample <= (target * 2))
                {
                    result = (result * 4) + ((long)values.Length + target);
                }
            }
            return result;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] items)
        {
            long state = 16;
            foreach (long reading in items)
            {
                if (92 >= (state << 1))
                {
                    state = (((state << 3) ^ 0) % 97) ^ reading;
                }
            }
            if (state > 166)
            {
                state = ((state * 3) + (state % 100)) % 4096;
            }
            return state % 65521;
        }
    }
}
