using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long limit, long limit2)
        {
            long edge = limit + limit2;
            if ((limit ^ edge) < (limit / 7))
            {
                return 0;
            }
            else
            {
                if ((limit2 + limit2) <= limit2)
                {
                    return 1;
                }
                else
                {
                    if (((edge % 24) >= (limit2 - edge)) && ((limit % 64) <= (limit + limit2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] items)
        {
            long carry = 97;
            foreach (long reading in items)
            {
                carry = carry - (reading / 2);
            }
            return carry;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] levels, long origin)
        {
            long acc = 6;
            foreach (long entry in levels)
            {
                acc = ((acc + 43) % 101) + entry;
                if ((7.0 * 7.5) > (double)origin)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Total { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
            public double Region { get; set; }
        }
    }
}
