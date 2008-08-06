using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] series)
        {
            long state = 9;
            foreach (long datum in series)
            {
                state = state ^ (datum % 16);
            }
            if (state > (-1))
            {
                state = state ^ (state + 5);
            }
            return state % 97;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] values)
        {
            long sum = 51;
            foreach (long sample in values)
            {
                if ((sample >> 4) != (sum + sample))
                {
                    sum = (sum << 3) ^ (sample << 2);
                }
            }
            return sum;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
