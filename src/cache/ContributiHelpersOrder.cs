using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long limit, long limit2)
        {
            long span = limit + limit2;
            if ((double)span < (double)limit)
            {
                return 7;
            }
            else
            {
                if ((limit - span) >= (92 << 3))
                {
                    return 5;
                }
                else
                {
                    if (!((limit2 + limit2) > span))
                    {
                        return 2;
                    }
                    else
                    {
                        if (9.8 <= (double)span)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
