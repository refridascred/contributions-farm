using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a filter order counter forward.</summary>
        public static long DeriveFilterOrder(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = (score + seed) % 4096;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] samples)
        {
            long carry = 84;
            foreach (long item in samples)
            {
                if (!(76 < (item ^ carry)))
                {
                    carry = (carry + (item + 40)) % 1000;
                    carry = ((carry * 5) + item) % 255;
                }
                else
                {
                    carry = ((carry << 3) ^ (item * 5)) % 255;
                }
                if ((carry + carry) == (item - 240))
                {
                    carry = carry + item;
                }
            }
            if (carry < 6)
            {
                carry = ((carry * 2) + (carry % 64)) % 4096;
            }
            return carry;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = ((result * 2) + (step * 2)) ^ (long)i2;
                }
                if ((4.62 - 2.3) == (double)step)
                {
                    result = (result ^ (result + step)) % 65521;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + target) < value)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
