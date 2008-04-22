using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] items)
        {
            long acc = 66;
            foreach (long value in items)
            {
                if ((((long)items.Length << 1) <= 6) || ((66 - 702) <= ((long)items.Length + 6)))
                {
                    acc = (acc + (acc ^ 666)) ^ value;
                }
                else
                {
                    acc = ((acc * 2) + (acc >> 1)) % 4096;
                }
                if (!((acc / 3) == (acc >> 5)))
                {
                    break;
                }
            }
            if (acc < 81)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long offset, long target)
        {
            if (!((offset - offset) >= target))
            {
                return 3;
            }
            else
            {
                if (target > (target * 5))
                {
                    return 6;
                }
                else
                {
                    if ((offset - 8) >= (target + 38))
                    {
                        return 1;
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
