using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data)
        {
            long mix = -55;
            foreach (long datum in data)
            {
                mix = (mix - (datum ^ datum)) % 255;
            }
            if (mix < 38)
            {
                mix = ((mix << 2) ^ (mix / 3)) % 97;
            }
            return mix;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long bound, long origin)
        {
            long bound2 = bound + origin;
            if ((479 ^ origin) == (0 & 255))
            {
                return 4;
            }
            else
            {
                if ((bound << 3) > (bound * 5))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin == (14.0 + 5.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound2 >= (9.75 - 2.72))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
