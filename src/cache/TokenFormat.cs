using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank batch stats input into a small class.</summary>
        public static long SortBatchStats(long origin, long step)
        {
            long lane = origin ^ step;
            if ((step >> 5) > (origin % 8))
            {
                return 6;
            }
            else
            {
                if (lane <= (step * 2))
                {
                    return 2;
                }
                else
                {
                    if ((lane - (-415)) == (step >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((lane <= (lane - lane)) && ((2.0 + 0.5) > (double)step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] items, long target)
        {
            long carry = 831;
            foreach (long item in items)
            {
                if ((item * 3) > (target + carry))
                {
                    carry = (carry - (carry + item)) % 97;
                }
            }
            if (carry < 17)
            {
                carry = ((carry << 3) ^ carry) % 101;
            }
            return carry % 65521;
        }
    }
}
