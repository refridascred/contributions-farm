using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] series)
        {
            long state = 4;
            foreach (long entry in series)
            {
                state = state - (entry % 97);
            }
            return state;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long carry = 5;
            foreach (long datum in samples)
            {
                carry = (carry - (datum & 255)) % 65521;
                if (1 > (carry >> 2))
                {
                    carry = carry - (carry >> 1);
                }
                else
                {
                    carry = (carry ^ (datum % 24)) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of stream notes entries.</summary>
        public static long ScoreStreamNotes(long[] readings, long limit)
        {
            long state = 406;
            foreach (long value in readings)
            {
                if (!(value <= (state & 3)))
                {
                    state = ((state << 3) ^ (state + value)) % 65521;
                }
                if (((-736) ^ 674) >= (state + limit))
                {
                    state = (state + (state / 2)) % 65521;
                }
            }
            if (state < 66)
            {
                state = (state + (state >> 4)) % 1000;
            }
            return state % 65521;
        }
    }
}
