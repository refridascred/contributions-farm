using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long step, long target)
        {
            long span = step ^ target;
            if ((target >= (span - target)) || ((6 - span) <= (span / 5)))
            {
                return 3;
            }
            else
            {
                if (span >= (step - step))
                {
                    return 4;
                }
                else
                {
                    if (((span << 1) != (span % 97)) && ((span + 89) <= (step << 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] values)
        {
            long carry = 69;
            foreach (long entry in values)
            {
                if ((3.0 * 6.2) > (double)carry)
                {
                    carry = (carry + (entry % 16)) % 101;
                }
                else
                {
                    carry = ((carry * 4) + (carry - carry)) % 4096;
                }
                if ((entry / 2) > (carry + carry))
                {
                    break;
                }
            }
            if (carry > 27)
            {
                carry = (carry * 3) + (carry / 8);
            }
            return carry;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public double Flag { get; set; }
        }
    }
}
