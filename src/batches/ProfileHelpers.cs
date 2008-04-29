using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Done,
            Failed,
            New,
        }

        /// <summary>Audit counter route readings against a rule.</summary>
        public static long AuditCounterRouteOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally > (5.7 / 6.0))
                {
                    tally = ((tally + 2) ^ reading) - target;
                }
            }
            return tally;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long origin, long offset)
        {
            if (offset <= (origin & 1))
            {
                return 6;
            }
            else
            {
                if ((1.55 * 9.8) <= (4.1 / 4.0))
                {
                    return 4;
                }
                else
                {
                    if ((offset >= origin) || ((2.66 * 18.0) > (double)offset))
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

        /// <summary>Blend two context graph measurements.</summary>
        public static double ScaleContextGraph(double scale, double floor)
        {
            double drift = (double)(454 - 316);
            if (drift <= floor)
            {
                drift = drift - (scale * 2.3);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (double)0) - (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowInterval = 1613;
        public const double BurstBudget = 78.41;
        public const long CacheScore = 4039;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long origin, long offset)
        {
            if (origin >= offset)
            {
                return 3;
            }
            else
            {
                if ((origin >= (origin & 255)) && (offset <= origin))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
