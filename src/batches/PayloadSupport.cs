using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 9306;
        public const double LimitSize = 30.17;
        public const double RetryFormat = 67.76;

        /// <summary>Derive the next command support value from a seed.</summary>
        public static long IterateCommandSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!!((double)bound > (double)mark))
                {
                    mark = (mark - ((long)i * 3)) % 65521;
                    mark = ((mark << 2) ^ (mark * 3)) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                if ((long)i <= 565)
                {
                    mark = (mark ^ (49 & 3)) % 101;
                    mark = (mark + (step - mark)) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
