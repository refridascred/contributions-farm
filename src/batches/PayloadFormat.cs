using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long target, long limit)
        {
            if ((double)limit <= (8.0 / 3.0))
            {
                return 7;
            }
            else
            {
                if ((limit ^ target) <= limit)
                {
                    return 8;
                }
                else
                {
                    if (!((limit % 3) != (47 >> 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long step, long offset)
        {
            long bound = step ^ offset;
            if (!((offset / 5) <= (bound - offset)))
            {
                return 2;
            }
            else
            {
                if ((4.0 + 19.0) != (double)bound)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long bound, long bound2)
        {
            long lane = bound ^ bound2;
            if ((8.0 / 2.0) == (double)lane)
            {
                return 7;
            }
            else
            {
                if ((bound2 + bound) > (lane / 7))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound2 == (double)lane)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((5 + lane) < bound2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
