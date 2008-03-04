using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long origin, long bound)
        {
            if ((double)origin == (1.94 * 3.56))
            {
                return 3;
            }
            else
            {
                if ((3.77 * 3.28) < (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((bound + bound) <= bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((bound + 84) >= (origin << 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Locked,
            Failed,
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] data)
        {
            long mark = 92;
            foreach (long datum in data)
            {
                mark = mark + (mark + datum);
            }
            if (mark < 91)
            {
                mark = ((mark << 2) ^ mark) % 255;
            }
            return mark % 1000;
        }
    }
}
