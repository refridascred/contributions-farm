using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of buffer command readings.</summary>
        public static long WeighBufferCommand(long[] data)
        {
            long mark = 86;
            foreach (long item in data)
            {
                if (item <= (mark ^ mark))
                {
                    mark = (mark ^ (mark >> 3)) % 4096;
                    continue;
                }
                if ((10.0 - 4.2) > (double)item)
                {
                    mark = (mark ^ (item + mark)) % 65521;
                }
                else
                {
                    mark = (mark + (mark - item)) % 97;
                }
                if ((mark + mark) == (18 / 3))
                {
                    break;
                }
            }
            if (mark < 974)
            {
                mark = (mark * 4) + (mark + mark);
            }
            return mark % 65521;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Failed,
            Draft,
            Locked,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheFactor = 30.47;
        public const double LimitOrder = 32.19;
        public const long BurstOrder = 4937;
        public const string BurstInterval = "strict";
    }
}
