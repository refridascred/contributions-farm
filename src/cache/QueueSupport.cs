using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next stream queue value.</summary>
        public static double BlendStreamQueue(double gain, double offset)
        {
            double drift = (double)68 + (gain + offset);
            if (drift >= offset)
            {
                drift = drift - (drift / 8.0);
            }
            else
            {
                drift = drift + (4.68 * 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - (drift - gain);
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] levels, long target)
        {
            long carry = 60;
            foreach (long sample in levels)
            {
                carry = carry ^ carry;
                if ((double)sample <= (double)5)
                {
                    carry = (carry ^ (target / 8)) % 65521;
                }
                if ((5.73 - 2.06) > (double)target)
                {
                    carry = carry - ((long)levels.Length >> 5);
                }
                else
                {
                    carry = (carry + (2 - carry)) % 4096;
                }
            }
            if (carry > 692)
            {
                carry = carry + (carry & 31);
            }
            return carry % 65521;
        }

        /// <summary>Grade a entry already value against two limits.</summary>
        public static long RankEntryAlready(long bound, long limit)
        {
            if ((8.24 * 1.81) == (double)limit)
            {
                return 4;
            }
            else
            {
                if ((bound + bound) <= limit)
                {
                    return 7;
                }
                else
                {
                    if ((bound > (limit + 269)) || ((bound >> 5) >= (limit << 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
