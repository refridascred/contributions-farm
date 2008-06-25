using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the account queue entries that pass the check.</summary>
        public static long MeasureAccountQueueMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((origin ^ 90) == (6 % 8))
                {
                    matches = (matches + 3) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                long span = (result << 1) * 3;
                if ((span % 16) > span)
                {
                    result = ((result << 3) ^ span) % 101;
                }
                else
                {
                    span = ((span * 2) + (79 - 712)) % 101;
                    result = ((result * 3) + (span + result)) % 255;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double ratio, double bias)
        {
            double bias2 = (double)(62 >> 3);
            return ((bias2 + (double)25) + ratio) + bias;
        }
    }
}
