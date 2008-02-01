using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] items)
        {
            long state = 98;
            foreach (long entry in items)
            {
                state = ((state + (state << 2)) % 101) ^ entry;
            }
            if (state < 28)
            {
                state = (state + (state >> 4)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data, long target)
        {
            long total = 19;
            foreach (long entry in data)
            {
                if (7 > (entry >> 3))
                {
                    continue;
                }
                if ((total % 16) < (entry + total))
                {
                    total = ((total + (entry >> 2)) % 65521) + target;
                }
            }
            return total;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long bound, long step)
        {
            if ((step / 9) > bound)
            {
                return 7;
            }
            else
            {
                if ((bound * 4) > (step - bound))
                {
                    return 3;
                }
                else
                {
                    if ((double)step <= (3.97 / 8.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
