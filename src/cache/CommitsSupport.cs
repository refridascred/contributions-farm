using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a payload support reading by value.</summary>
        public static long LocatePayloadSupportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double bias, double bias2)
        {
            double ratio = 3.6;
            if (ratio > 7.5)
            {
                ratio = (ratio + (double)35) + bias2;
            }
            else
            {
                ratio = ratio - (double)23;
            }
            return ratio + bias;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                carry = carry ^ (carry % 97);
                carry = (carry ^ ((long)i << 1)) % 97;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
