using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long floor, long bound)
        {
            long span = floor - bound;
            if (span >= (bound >> 5))
            {
                return 7;
            }
            else
            {
                if ((bound * 5) <= floor)
                {
                    return 0;
                }
                else
                {
                    if ((floor ^ bound) >= (floor - 328))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((span & 63) >= bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (state ^ seed) ^ (long)i2;
                }
                if ((((-5) + seed) < (state % 12)) && ((double)state >= (double)seed))
                {
                    state = (state + seed) % 4096;
                }
                state = (state ^ state) % 97;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
