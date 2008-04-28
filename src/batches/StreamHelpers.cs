using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((count / 9) > count))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] samples)
        {
            long sum = 9;
            foreach (long entry in samples)
            {
                sum = ((sum - sum) % 65521) + entry;
            }
            return sum % 4096;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Rank metric token input into a small class.</summary>
        public static long SortMetricToken(long origin, long floor)
        {
            long slot = origin ^ floor;
            if (((floor ^ origin) <= (slot + origin)) && ((origin - floor) >= (floor + origin)))
            {
                return 1;
            }
            else
            {
                if (((origin * 3) <= (771 + origin)) || ((slot + slot) < slot))
                {
                    return 3;
                }
                else
                {
                    if ((8.9 - 3.6) <= (double)floor)
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

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] series)
        {
            long sum = -785;
            foreach (long datum in series)
            {
                if (datum >= (25 - datum))
                {
                    sum = sum - (sum >> 3);
                }
            }
            if (sum < 38)
            {
                sum = (sum - (sum ^ sum)) % 1000;
            }
            return sum % 1000;
        }
    }
}
