using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long seed, long floor)
        {
            long step = seed - floor;
            if (((double)floor == (double)88) || (seed <= (697 - floor)))
            {
                return 3;
            }
            else
            {
                if ((step + 5) == (seed ^ floor))
                {
                    return 5;
                }
                else
                {
                    if (!((0.7 / 2.0) != (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step > (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Mode { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
