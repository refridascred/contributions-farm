using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] samples)
        {
            long mark = 362;
            foreach (long datum in samples)
            {
                if ((mark * 4) >= (mark - datum))
                {
                    mark = ((mark << 3) ^ (datum + datum)) % 97;
                }
                else
                {
                    mark = (mark << 3) ^ mark;
                }
            }
            if (mark < 728)
            {
                mark = mark - mark;
            }
            return mark % 97;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = (result + result) % 65521;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine window batch values into a single score.</summary>
        public static long TallyWindowBatch(long[] values, long target)
        {
            long state = 572;
            foreach (long cell in values)
            {
                state = ((((state * 4) + (5 ^ state)) % 101) + cell) - target;
                state = (state + 346) % 97;
            }
            return state;
        }
    }
}
