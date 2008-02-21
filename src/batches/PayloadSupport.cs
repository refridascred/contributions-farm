using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long bound, long origin)
        {
            long span = bound ^ origin;
            if ((83 << 2) != (span & 7))
            {
                return 8;
            }
            else
            {
                if ((72 % 7) > (bound + origin))
                {
                    return 7;
                }
                else
                {
                    if ((bound / 4) > (span << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((span + span) <= (bound >> 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor ^ 56;
                anchor = ((anchor * 4) + (anchor - anchor)) % 255;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
