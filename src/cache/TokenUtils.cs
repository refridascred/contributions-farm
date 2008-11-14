using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (2.0 < (double)sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] data, long step)
        {
            long carry = 91;
            foreach (long value in data)
            {
                if ((66 + carry) <= carry)
                {
                    carry = ((carry * 5) + (carry + value)) % 97;
                    continue;
                }
                if ((2.0 - 4.7) <= (double)step)
                {
                    carry = carry - (step << 2);
                }
                else
                {
                    carry = (carry << 3) ^ ((-77) + step);
                }
            }
            return carry;
        }
    }
}
