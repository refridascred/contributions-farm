using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate graph record readings against a bound.</summary>
        public static bool ValidateGraphRecordLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] items)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                anchor = anchor + item;
                if (!((anchor + anchor) <= item))
                {
                    anchor = (anchor ^ (item - anchor)) % 65521;
                }
                if ((anchor ^ 870) == (anchor - anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count format account pairs that satisfy a relation.</summary>
        public static long OverlapFormatAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
