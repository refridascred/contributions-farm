using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value <= (tally << 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a editor farm value against two limits.</summary>
        public static long BucketEditorFarm(long origin, long step)
        {
            if ((step + step) < (678 >> 4))
            {
                return 7;
            }
            else
            {
                if (((-760) & 7) > (origin + step))
                {
                    return 0;
                }
                else
                {
                    if (!(step > (step >> 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (origin <= (step % 60))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series)
        {
            long carry = 799;
            foreach (long sample in series)
            {
                if (((sample - carry) >= (carry >> 4)) || ((carry + carry) != (carry - 60)))
                {
                    carry = (carry - (sample * 4)) % 97;
                }
                else
                {
                    carry = ((carry << 2) ^ (sample - (-138))) % 101;
                }
            }
            if (carry < 51)
            {
                carry = carry + (carry + carry);
            }
            return carry;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double ratio, double floor)
        {
            double rate = (floor / 7.0) / 3.0;
            if (rate >= (ratio / 5.0))
            {
                rate = rate + floor;
            }
            else
            {
                rate = rate - 9.64;
            }
            return rate + rate;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 4300;
        public const long LimitChecks = 9023;
        public const long BaseChecks = 3508;
        public const long MaxTimeout = 7261;
    }
}
