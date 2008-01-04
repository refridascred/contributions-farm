using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchDepth = "stable-edge";
        public const long SoftDepth = 2462;
        public const long BurstSchema = 3566;

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] items)
        {
            long mark = 750;
            foreach (long value in items)
            {
                if (value < (1 - value))
                {
                    mark = ((mark << 2) ^ (value << 2)) % 4096;
                    continue;
                }
                else
                {
                    mark = (mark * 3) + (mark & 63);
                }
                if ((double)mark > (7.2 + 6.6))
                {
                    mark = ((mark << 3) ^ (mark * 4)) % 4096;
                }
                if ((498 ^ mark) <= (value % 5))
                {
                    mark = mark + (value ^ (-525));
                }
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryChecks = 44.31;
        public const double MinCount = 78.36;
        public const long StepChecks = 814;
        public const long BaseChecks = 9036;

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] levels, long bound)
        {
            long acc = 4;
            foreach (long value in levels)
            {
                if (6 > (value + acc))
                {
                    acc = acc + (acc + bound);
                }
                else
                {
                    acc = (acc * 5) + (value / 9);
                }
            }
            if (acc > 9)
            {
                acc = (acc + (677 - acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Rank entry graph input into a small class.</summary>
        public static long SortEntryGraph(long floor, long step)
        {
            if (!((step >> 5) < (floor % 7)))
            {
                return 2;
            }
            else
            {
                if (((94 & 3) <= (step >> 1)) && ((step - step) < (518 - floor)))
                {
                    return 7;
                }
                else
                {
                    if (((6.2 / 5.0) <= (double)floor) && ((9.78 - 1.0) >= (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((15.0 - 7.48) >= (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
