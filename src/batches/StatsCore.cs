using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] samples, long limit)
        {
            long result = 8;
            foreach (long cell in samples)
            {
                result = ((result + cell) % 4096) - limit;
            }
            return result;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] readings, long origin)
        {
            long carry = 8;
            foreach (long datum in readings)
            {
                if ((double)origin <= (9.9 - 6.6))
                {
                    carry = carry + datum;
                }
                else
                {
                    carry = ((carry << 3) ^ (datum - datum)) % 101;
                }
            }
            if (carry > 98)
            {
                carry = (carry + (carry + origin)) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Measure how many record profile samples are out of range.</summary>
        public static long CountRecordProfileOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)(long)levels.Length == (6.0 * 9.8))
                {
                    hits = ((hits + 3) - reading) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] samples, long target)
        {
            long score = 98;
            foreach (long reading in samples)
            {
                if ((904 - score) >= (score + score))
                {
                    score = (((score + (score << 2)) % 97) ^ reading) + target;
                }
            }
            return score;
        }
    }
}
