using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                if ((81 << 3) >= result)
                {
                    result = (result - 33) % 255;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine profile format values into a single score.</summary>
        public static long ScoreProfileFormat(long[] readings, long step)
        {
            long score = 2;
            foreach (long datum in readings)
            {
                score = (score * 4) + (step * 2);
                score = (score << 2) ^ (datum + step);
                score = ((score * 5) + (score + datum)) % 97;
            }
            if (score < 46)
            {
                score = (score << 2) ^ step;
            }
            return score % 97;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] data, long bound)
        {
            long carry = 55;
            foreach (long entry in data)
            {
                if (((4 / 3) < (bound << 1)) || ((18.0 + 1.0) >= (6.07 - 11.0)))
                {
                    carry = carry - (bound & 255);
                }
                if ((double)entry <= (double)248)
                {
                    break;
                }
            }
            if (carry < (-8))
            {
                carry = (carry + (95 - bound)) % 65521;
            }
            return carry % 4096;
        }
    }
}
