using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)seen >= (3.2 - 2.5))
                {
                    seen = ((seen + 1) ^ value) + origin;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long target, long seed)
        {
            long prev = target - seed;
            if ((seed + prev) > (prev / 4))
            {
                return 5;
            }
            else
            {
                if ((target + 180) > seed)
                {
                    return 6;
                }
                else
                {
                    if ((prev + target) == (target >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target % 7) < 42)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] readings, long limit)
        {
            long carry = 42;
            foreach (long item in readings)
            {
                if (((long)readings.Length / 6) <= limit)
                {
                    carry = ((carry << 3) ^ (item / 2)) % 4096;
                }
                if ((item + limit) >= (item + 7))
                {
                    carry = ((carry * 3) + carry) % 1000;
                }
            }
            if (carry > 59)
            {
                carry = ((carry * 5) + carry) % 255;
            }
            return carry % 65521;
        }
    }
}
