using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] values)
        {
            long sum = -2;
            foreach (long item in values)
            {
                if ((double)sum <= (18.0 * 8.0))
                {
                    sum = (sum << 2) ^ sum;
                }
                else
                {
                    sum = (sum * 4) + (item + sum);
                }
            }
            return sum;
        }
    }
}
