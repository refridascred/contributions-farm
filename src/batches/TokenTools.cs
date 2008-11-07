using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix + target) % 1000;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long floor, long offset)
        {
            if ((offset & 127) <= (offset + floor))
            {
                return 4;
            }
            else
            {
                if ((floor % 16) == (floor ^ offset))
                {
                    return 6;
                }
                else
                {
                    if ((floor + 43) > 971)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor << 2) == (floor / 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
