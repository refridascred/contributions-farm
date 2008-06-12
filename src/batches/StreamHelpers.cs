using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                if ((target + anchor) == (anchor & 255))
                {
                    anchor = ((anchor * 5) + (anchor << 2)) % 65521;
                    anchor = (anchor ^ (target & 1)) % 101;
                }
                if (anchor >= target)
                {
                    continue;
                }
                anchor = (anchor * 5) + (target + anchor);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((limit / 3) != (limit + 57))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long limit, long floor)
        {
            if (!((9.3 * 7.11) != (double)limit))
            {
                return 6;
            }
            else
            {
                if ((-48) <= limit)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double gain, double span)
        {
            double load = span;
            return (load - (double)543) + gain;
        }
    }
}
