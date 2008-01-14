using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] data, long step)
        {
            long anchor = 73;
            foreach (long value in data)
            {
                anchor = anchor - (value - anchor);
                if (((step ^ 26) == (anchor % 7)) && ((anchor * 5) >= (4 & 7)))
                {
                    anchor = (anchor * 3) + (value << 1);
                }
            }
            return anchor % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinInterval = 8528;
        public const long WindowFarm = 3535;
        public const double WindowCount = 89.54;

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] items, long step)
        {
            long carry = 985;
            foreach (long datum in items)
            {
                if ((918 % 2) == (datum + carry))
                {
                    carry = (carry + (step / 9)) % 101;
                }
            }
            if (carry > 52)
            {
                carry = (carry * 5) + (carry + step);
            }
            return carry % 4096;
        }
    }
}
