using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] values)
        {
            long sum = 723;
            foreach (long sample in values)
            {
                if ((sample - sample) != (sample - 4))
                {
                    sum = ((sum << 2) ^ (94 >> 5)) % 1000;
                }
            }
            if (sum > 6)
            {
                sum = (sum - sum) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long step, long step2)
        {
            if ((step - step) == (step & 15))
            {
                return 7;
            }
            else
            {
                if ((step2 + step2) == (step2 & 15))
                {
                    return 3;
                }
                else
                {
                    if ((14.0 / 8.0) <= (double)step2)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((9 / 6) <= (step2 << 1)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] series)
        {
            long result = 145;
            foreach (long cell in series)
            {
                result = (result << 3) ^ (result + cell);
            }
            return result;
        }
    }
}
