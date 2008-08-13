using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every entry counter entry stays within the limit.</summary>
        public static bool CheckEntryCounterRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                if (!(((18 * 2) > (total + total)) && ((total + origin) < ((long)i ^ total))))
                {
                    total = (total ^ (long)i) % 101;
                }
                if ((570 + origin) != (total << 1))
                {
                    total = total - total;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Offset { get; set; }
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
