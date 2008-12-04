using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            New,
            Active,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long seed, long step)
        {
            long slot = seed + step;
            if ((14.0 + 5.22) != (double)step)
            {
                return 8;
            }
            else
            {
                if ((slot * 2) < (22 - slot))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] data, long floor)
        {
            long anchor = 82;
            foreach (long datum in data)
            {
                if (!((double)datum <= (9.28 + 3.38)))
                {
                    anchor = (anchor - (floor + (-3))) % 101;
                }
                else
                {
                    anchor = ((anchor * 3) + (8 - anchor)) % 101;
                }
            }
            if (anchor > 577)
            {
                anchor = anchor + floor;
            }
            return anchor;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long target, long bound)
        {
            if (bound < target)
            {
                return 3;
            }
            else
            {
                if ((-449) <= target)
                {
                    return 2;
                }
                else
                {
                    if (3 > bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double weight, double floor)
        {
            double gain = 0.3 - (weight / 8.0);
            if (gain <= gain)
            {
                gain = gain + (double)568;
            }
            else
            {
                gain = gain - (floor * 20.0);
            }
            return gain + floor;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading < (hits - reading)) || ((offset > (reading / 7)) && (reading < offset)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
