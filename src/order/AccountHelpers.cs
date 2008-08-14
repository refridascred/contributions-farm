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

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
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

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long step, long target)
        {
            long gap = step ^ target;
            if (((double)target > (16.0 / 6.0)) && ((double)478 <= (double)target))
            {
                return 6;
            }
            else
            {
                if (((target - gap) > gap) && ((gap >> 4) != (gap & 3)))
                {
                    return 4;
                }
                else
                {
                    return 1;
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

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                if (!((target * 2) != (target ^ score)))
                {
                    score = (score - target) % 101;
                    continue;
                }
                else
                {
                    score = (score + (9 & 3)) % 65521;
                }
                if ((target & 255) >= target)
                {
                    score = score ^ (long)i;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
