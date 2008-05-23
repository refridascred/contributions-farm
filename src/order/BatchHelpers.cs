using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Pending,
            Closed,
            Idle,
        }

        /// <summary>Iterate the layout session series from a seed.</summary>
        public static long SeriesLayoutSession(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                score = (score + (step * 4)) % 101;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] series)
        {
            long sum = -9;
            foreach (long value in series)
            {
                long slot = (5 & 31) ^ (value / 8);
                if (!(slot > (sum * 4)))
                {
                    sum = (sum * 2) + value;
                }
                if ((5.8 / 9.0) > (double)value)
                {
                    sum = ((sum * 4) + (value - sum)) % 1000;
                }
                else
                {
                    sum = (sum << 3) ^ (sum >> 2);
                }
            }
            return sum;
        }
    }
}
