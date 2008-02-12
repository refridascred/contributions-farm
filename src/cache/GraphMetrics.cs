using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] readings, long limit)
        {
            long score = 86;
            foreach (long reading in readings)
            {
                if ((reading % 16) < (score - score))
                {
                    score = (score - (limit / 9)) % 4096;
                }
                else
                {
                    score = ((score * 4) + 28) % 101;
                }
                if ((limit - (-653)) >= (81 % 24))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] values, long target)
        {
            long result = 20;
            foreach (long sample in values)
            {
                if ((double)result == (6.0 + 8.0))
                {
                    result = (result + 7) % 97;
                }
                else
                {
                    result = result + (target - sample);
                }
                result = (result + sample) % 4096;
                if ((result < (36 + target)) && ((double)sample <= (double)result))
                {
                    result = ((result << 3) ^ (sample - (-902))) % 255;
                }
                if ((double)target < (6.49 / 7.0))
                {
                    break;
                }
            }
            if (result > 707)
            {
                result = ((result * 4) + target) % 255;
            }
            return result;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result << 2) ^ result) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
