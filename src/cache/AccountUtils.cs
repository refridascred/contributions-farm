using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series, long origin)
        {
            long mark = 3;
            foreach (long value in series)
            {
                mark = mark + origin;
                mark = ((mark * 2) + value) % 1000;
            }
            if (mark > 68)
            {
                mark = mark ^ (long)series.Length;
            }
            return mark % 1000;
        }

        /// <summary>Locate a entry channel reading by value.</summary>
        public static long FindEntryChannelIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long step, long origin)
        {
            if ((1.57 / 3.0) != (double)step)
            {
                return 1;
            }
            else
            {
                if (!((step * 3) >= (origin / 7)))
                {
                    return 3;
                }
                else
                {
                    if (!((origin ^ step) >= step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((245 / 3) != (origin / 6))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
