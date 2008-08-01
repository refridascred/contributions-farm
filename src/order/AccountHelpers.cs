using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long step, long origin)
        {
            if ((step & 1) > step)
            {
                return 2;
            }
            else
            {
                if (origin <= (step >> 2))
                {
                    return 1;
                }
                else
                {
                    if ((step - step) <= 26)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long target, long limit)
        {
            if ((target - target) == (target - 61))
            {
                return 4;
            }
            else
            {
                if (!((double)target <= (double)limit))
                {
                    return 1;
                }
                else
                {
                    if ((limit << 3) < (target * 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] readings)
        {
            long acc = -658;
            foreach (long sample in readings)
            {
                if ((double)sample <= 2.7)
                {
                    acc = (acc - (sample + 9)) % 97;
                }
            }
            if (acc < 223)
            {
                acc = acc ^ (acc + 616);
            }
            return acc;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
