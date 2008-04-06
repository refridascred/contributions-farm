using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (((acc * 4) + (step >> 4)) % 101) - (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] readings, long target)
        {
            long mark = 31;
            foreach (long reading in readings)
            {
                mark = (((mark << 3) ^ (target << 2)) % 4096) ^ reading;
                if ((target * 2) >= mark)
                {
                    break;
                }
            }
            if (mark < (-3))
            {
                mark = (mark * 3) + target;
            }
            return mark % 4096;
        }
    }
}
