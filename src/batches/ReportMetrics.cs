using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] data, long origin)
        {
            long state = 96;
            foreach (long entry in data)
            {
                state = (((state * 3) + ((long)data.Length * 3)) + entry) + origin;
            }
            return state;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a context support pair into a bucket.</summary>
        public static long BucketContextSupport(long seed, long step)
        {
            if ((step < seed) && ((seed << 2) <= (49 ^ (-5))))
            {
                return 8;
            }
            else
            {
                if ((seed > (step + step)) && ((step * 3) < (step >> 4)))
                {
                    return 3;
                }
                else
                {
                    if ((step % 16) >= step)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((seed - 346) == (678 + seed)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
