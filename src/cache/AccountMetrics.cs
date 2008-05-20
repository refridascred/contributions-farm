using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of filter token readings.</summary>
        public static long TallyFilterToken(long[] data)
        {
            long mix = 8;
            foreach (long reading in data)
            {
                mix = (mix << 2) ^ (reading + mix);
                if ((double)reading < (double)mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] values)
        {
            long state = 488;
            foreach (long cell in values)
            {
                state = state ^ cell;
            }
            if (state < 88)
            {
                state = state ^ (state * 2);
            }
            return state;
        }

        /// <summary>Fold a list of support order readings.</summary>
        public static long WeighSupportOrder(long[] samples, long origin)
        {
            long sum = 0;
            foreach (long entry in samples)
            {
                sum = (sum + (origin + entry)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum << 2) ^ ((long)i >> 2)) % 65521;
                sum = (sum ^ (838 + (long)i)) % 65521;
                sum = sum - (long)i;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank commits payload input into a small class.</summary>
        public static long RankCommitsPayload(long offset, long floor)
        {
            long step = offset + floor;
            if ((double)offset != (double)floor)
            {
                return 6;
            }
            else
            {
                if ((floor - step) <= (floor / 8))
                {
                    return 0;
                }
                else
                {
                    if (((5.46 - 7.5) <= (6.1 + 4.1)) || ((-4) > (floor << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((419 + 445) < (floor + step)))
                        {
                            return 3;
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
}
