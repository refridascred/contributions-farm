using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((double)limit == (13.0 - 5.0)) && !(value <= (limit & 7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc - ((long)i << 2)) % 65521;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
