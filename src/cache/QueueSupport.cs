using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine queue buffer values into a single score.</summary>
        public static long DigestQueueBuffer(long[] data, long step)
        {
            long mark = 2;
            foreach (long item in data)
            {
                if ((mark * 3) > step)
                {
                    mark = (((mark * 2) + (step - mark)) % 97) + item;
                }
            }
            if (mark > (-4))
            {
                mark = mark - (mark & 255);
            }
            return mark % 1000;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
