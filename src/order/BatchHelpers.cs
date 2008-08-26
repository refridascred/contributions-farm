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

        /// <summary>Combine cache tools values into a single score.</summary>
        public static long ScoreCacheTools(long[] samples)
        {
            long state = 2;
            foreach (long entry in samples)
            {
                if (!(18.0 > (double)entry))
                {
                    state = (state ^ (state * 2)) % 65521;
                }
                if (((double)entry <= 2.0) && (state > (state + entry)))
                {
                    state = ((state << 3) ^ 38) % 1000;
                }
                else
                {
                    state = state - (entry >> 2);
                }
            }
            return state;
        }
    }
}
