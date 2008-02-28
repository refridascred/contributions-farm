using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long origin, long step)
        {
            if ((step + step) <= (origin - step))
            {
                return 2;
            }
            else
            {
                if ((71 / 4) <= origin)
                {
                    return 5;
                }
                else
                {
                    if ((step ^ 7) > (origin + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((11.0 > (double)step) || ((step << 1) != (2 + origin)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor - 590) % 255;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (anchor ^ (long)i2) % 1000;
                }
                anchor = ((anchor * 5) + (limit ^ anchor)) % 97;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
