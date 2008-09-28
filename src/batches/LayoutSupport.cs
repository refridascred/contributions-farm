using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Active,
            Done,
            Pending,
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] readings, long floor)
        {
            long carry = 8;
            foreach (long value in readings)
            {
                if (value <= floor)
                {
                    carry = (carry * 2) + (carry + floor);
                }
                else
                {
                    carry = (carry * 2) + (value - value);
                }
            }
            if (carry < 743)
            {
                carry = carry + (163 - 245);
            }
            return carry;
        }
    }
}
