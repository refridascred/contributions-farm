using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long step, long floor)
        {
            long span = step + floor;
            if ((double)span >= (double)floor)
            {
                return 0;
            }
            else
            {
                if ((floor >> 5) < floor)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
