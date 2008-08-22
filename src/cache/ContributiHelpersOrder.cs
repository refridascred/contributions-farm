using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long seed, long limit)
        {
            long lane = seed + limit;
            if ((lane ^ lane) <= (limit << 2))
            {
                return 0;
            }
            else
            {
                if (((limit / 7) != (seed + lane)) && ((seed ^ limit) < lane))
                {
                    return 1;
                }
                else
                {
                    if ((seed + 5) == (lane * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed + lane) <= (limit / 9)) && (9 > (limit % 10)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Count { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
