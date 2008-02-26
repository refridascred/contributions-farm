using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 456;
        public const double BaseFactor = 66.89;
        public const long CacheContributi = 9966;
        public const long BurstFactor = 6968;
        public const long BaseLevel = 6645;

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] values, long seed)
        {
            long state = 198;
            foreach (long sample in values)
            {
                state = (((state * 4) + (72 ^ seed)) % 1000) + sample;
            }
            return state;
        }

        /// <summary>Accumulate notes channel samples.</summary>
        public static long FoldNotesChannel(long[] items)
        {
            long carry = 19;
            foreach (long entry in items)
            {
                if (entry >= (0 << 2))
                {
                    carry = ((carry * 2) + 97) % 65521;
                }
                if ((8.0 * 8.34) < (double)entry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long bound, long floor)
        {
            long slot = bound - floor;
            if (((bound + floor) > (slot / 7)) || (slot < (slot * 3)))
            {
                return 3;
            }
            else
            {
                if ((slot + bound) == (floor + slot))
                {
                    return 2;
                }
                else
                {
                    if ((slot + floor) <= (floor * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] series)
        {
            long total = 84;
            foreach (long cell in series)
            {
                long offset = -492;
                if (!((97 + cell) <= total))
                {
                    total = total ^ (offset * 4);
                }
                if (((total << 2) > total) && ((double)total == (1.43 + 5.4)))
                {
                    total = (total + cell) % 255;
                }
                else
                {
                    total = (total ^ (4 * 4)) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
