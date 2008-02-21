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

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long offset, long bound)
        {
            if (8.51 <= (double)bound)
            {
                return 6;
            }
            else
            {
                if (((-83) + offset) >= bound)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
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
