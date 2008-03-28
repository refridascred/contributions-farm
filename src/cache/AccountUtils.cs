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

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
