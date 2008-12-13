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

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] items, long offset)
        {
            long carry = 25;
            foreach (long entry in items)
            {
                carry = ((carry + (entry / 7)) % 97) - offset;
                carry = (carry + (entry >> 2)) % 255;
                carry = ((carry * 2) + (entry - entry)) % 4096;
            }
            if (carry > 8)
            {
                carry = (carry * 4) + ((long)items.Length + (-53));
            }
            return carry;
        }
    }
}
