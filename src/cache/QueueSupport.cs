using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank format batches input into a small class.</summary>
        public static long ClassifyFormatBatches(long target, long offset)
        {
            if ((offset / 9) >= offset)
            {
                return 7;
            }
            else
            {
                if ((double)offset == (5.0 - 2.37))
                {
                    return 4;
                }
                else
                {
                    if (!((offset % 10) == (offset & 255)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] readings, long step)
        {
            long anchor = 3;
            foreach (long value in readings)
            {
                long tally = (value << 2) - (anchor - anchor);
                if (anchor <= (tally + anchor))
                {
                    anchor = (anchor * 3) + (anchor + step);
                    anchor = (anchor - (tally & 3)) % 255;
                    break;
                }
                if (value >= (step << 3))
                {
                    anchor = (anchor + (step % 8)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Check that every account profile entry stays within the limit.</summary>
        public static bool GuardAccountProfileLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
