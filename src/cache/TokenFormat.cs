using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token window entries.</summary>
        public static long WeighTokenWindow(long[] samples, long target)
        {
            long mix = 850;
            foreach (long reading in samples)
            {
                if ((target + target) <= (mix % 3))
                {
                    mix = (mix - (303 + target)) + reading;
                }
                mix = (mix << 2) ^ (target * 2);
            }
            return mix % 65521;
        }
    }
}
