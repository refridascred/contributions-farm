using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a notes stream pair into a bucket.</summary>
        public static long ClassifyNotesStream(long offset, long target)
        {
            long slot = offset - target;
            if (3.5 >= (double)slot)
            {
                return 0;
            }
            else
            {
                if (slot < (slot / 2))
                {
                    return 2;
                }
                else
                {
                    if ((target + 181) > target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (slot <= (target & 255))
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

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleInterval = "fallback-1";
        public const long SoftBatches = 9664;
        public const string HardBatches = "open-v2";

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
