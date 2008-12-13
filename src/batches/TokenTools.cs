using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long step, long step2)
        {
            if (5.4 > (double)step2)
            {
                return 5;
            }
            else
            {
                if (((double)step <= (17.0 - 18.0)) && (9.88 < (double)step))
                {
                    return 8;
                }
                else
                {
                    if ((double)step == (7.76 + 16.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((step ^ step) > (step + step2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor - (anchor * 3)) % 65521;
                if ((double)(long)i <= (15.0 / 3.0))
                {
                    anchor = (anchor + (seed + anchor)) % 65521;
                    anchor = (anchor ^ (seed + anchor)) % 4096;
                }
                anchor = anchor ^ (seed - seed);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
