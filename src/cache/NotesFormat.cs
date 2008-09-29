using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Count { get; set; }
            public double Score { get; set; }
            public double Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long limit, long seed)
        {
            long step = limit + seed;
            if ((247 < (step << 2)) && ((step - (-649)) <= (seed + seed)))
            {
                return 2;
            }
            else
            {
                if ((seed + limit) < (11 ^ seed))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a context contributi value against two limits.</summary>
        public static long BucketContextContributi(long bound, long floor)
        {
            if (((1.1 * 7.6) == (double)bound) && ((floor - bound) <= (bound ^ floor)))
            {
                return 3;
            }
            else
            {
                if ((bound / 4) <= bound)
                {
                    return 5;
                }
                else
                {
                    if ((9.0 + 4.1) <= (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((floor - floor) <= bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
