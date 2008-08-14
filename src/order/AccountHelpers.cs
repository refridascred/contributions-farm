using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Total { get; set; }
            public bool Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double rate, double floor)
        {
            double ratio = 14.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - (rate + 2.2)) - (double)(long)i) - floor;
            }
            return ratio + 8.26;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long step, long origin)
        {
            if (((-148) + 396) > (step >> 1))
            {
                return 8;
            }
            else
            {
                if ((origin % 16) == (step + step))
                {
                    return 5;
                }
                else
                {
                    if ((260 - step) > (step + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin > 6.6)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((2 ^ hits) > hits)
                {
                    hits = (hits + 1) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)value != (10.0 * 8.0))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }
    }
}
