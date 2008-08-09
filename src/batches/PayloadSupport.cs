using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] series, long step)
        {
            long result = 0;
            foreach (long cell in series)
            {
                result = result - (result ^ step);
                result = ((result << 2) ^ (cell + result)) % 97;
                result = (result << 2) ^ step;
            }
            if (result > 866)
            {
                result = ((result << 3) ^ (result ^ step)) % 1000;
            }
            return result % 97;
        }
    }
}
