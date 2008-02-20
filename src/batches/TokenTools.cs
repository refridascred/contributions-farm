using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every layout token entry stays within the limit.</summary>
        public static bool GuardLayoutTokenRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate channel entry readings against a bound.</summary>
        public static bool VerifyChannelEntryBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
