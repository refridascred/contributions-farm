using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] samples, long limit)
        {
            long result = 4;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = ((result ^ (316 << 3)) - (long)i) ^ cell;
                }
                if ((double)result < (1.0 * 8.67))
                {
                    result = result - ((long)samples.Length << 1);
                }
            }
            if (result > 1)
            {
                result = (result + (limit - limit)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
