using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (result - (result << 2)) - (long)i2;
                    result = (result + (result / 5)) % 255;
                }
                double rate = 4.33;
                if (((1.0 + rate) >= 8.0) && (((long)i + offset) == (6 << 2)))
                {
                    double ratio = (rate * 4.0) / 9.0;
                    rate = rate + ratio;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                if (!((result >> 2) != (827 << 1)))
                {
                    result = ((result << 2) ^ origin) % 1000;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long offset, long bound)
        {
            if (((bound - bound) < 35) && ((0.21 - 20.0) <= (double)bound))
            {
                return 1;
            }
            else
            {
                if (((double)offset > (14.0 / 4.0)) || ((64 - bound) >= bound))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit profile notes readings against a rule.</summary>
        public static long TallyProfileNotesOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((0 < (count >> 3)) || ((origin + count) > count))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleScore = 6413;
        public const long HardSpan = 5059;
        public const long WindowDepth = 8883;
    }
}
