using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a tools record reading by value.</summary>
        public static long FindToolsRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record already samples.</summary>
        public static long WeighRecordAlready(long[] samples)
        {
            long carry = 4;
            foreach (long cell in samples)
            {
                carry = (carry + carry) % 1000;
                if ((cell / 4) < (8 - cell))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Grade a profile layout value against two limits.</summary>
        public static long SortProfileLayout(long offset, long origin)
        {
            long slot = offset - origin;
            if ((offset & 31) == (1 * 5))
            {
                return 6;
            }
            else
            {
                if (slot > (7 + 1))
                {
                    return 3;
                }
                else
                {
                    if (!((10 - origin) <= (offset + slot)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((735 >= (slot + offset)) && ((origin << 2) > (origin + slot)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
