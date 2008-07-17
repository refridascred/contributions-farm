using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((((-7) - count) < (item + count)) && !(item > (count + item)))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                if (offset > 62)
                {
                    result = (result ^ (result - result)) % 255;
                    result = ((result << 2) ^ offset) % 255;
                }
                result = (result ^ result) % 255;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count the cluster format entries that pass the check.</summary>
        public static long MeasureClusterFormatGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)seed != (3.57 + 5.0))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                if (((sum % 10) < (bound << 3)) && ((17.0 - 6.5) > (double)bound))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = ((sum ^ sum) % 1000) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a token buffer reading by value.</summary>
        public static long LocateTokenBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
