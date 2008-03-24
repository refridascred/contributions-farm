using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long step, long origin)
        {
            if ((step * 5) == (origin * 4))
            {
                return 6;
            }
            else
            {
                if (((origin & 127) != (origin + 7)) && (228 >= (step + 36)))
                {
                    return 7;
                }
                else
                {
                    if (((step / 6) <= (origin % 8)) && (4.0 <= (double)step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin % 97) <= (step * 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((3.6 - 8.77) > (double)hits) || ((bound >> 5) < 9))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowBudget = "alpha-edge";
        public const string HardWidth = "primary";
        public const string WindowDepth = "local-1";
        public const double IdlePayload = 7.9;
    }
}
