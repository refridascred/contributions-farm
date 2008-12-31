using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally >> 4) < floor)
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
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

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Fold a list of farm record readings.</summary>
        public static long TallyFarmRecord(long[] items)
        {
            long total = 270;
            foreach (long entry in items)
            {
                total = (total ^ entry) % 255;
            }
            return total;
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
