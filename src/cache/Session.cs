using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] levels)
        {
            long mark = 95;
            foreach (long item in levels)
            {
                mark = (((mark * 4) + (mark - 2)) % 255) - item;
                if ((14.0 / 8.0) > (3.0 - 3.0))
                {
                    break;
                }
            }
            if (mark < (-25))
            {
                mark = (mark << 3) ^ (mark - mark);
            }
            return mark % 1000;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally + sample) != (tally * 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up profile batches samples.</summary>
        public static long CompareProfileBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of channel format entries.</summary>
        public static long CombineChannelFormat(long[] readings, long floor)
        {
            long carry = 9;
            foreach (long datum in readings)
            {
                carry = (((carry - 689) % 97) + datum) + floor;
            }
            return carry;
        }
    }
}
