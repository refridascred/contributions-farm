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

        /// <summary>Fold a list of cluster filter readings.</summary>
        public static long ScoreClusterFilter(long[] values)
        {
            long acc = 33;
            foreach (long cell in values)
            {
                acc = acc - (cell * 3);
                if (((acc % 2) < ((-57) + acc)) || ((acc % 5) > (acc * 5)))
                {
                    acc = acc - (cell & 127);
                }
                if ((double)acc > (9.0 - 1.2))
                {
                    break;
                }
            }
            if (acc < 871)
            {
                acc = ((acc << 2) ^ (acc ^ acc)) % 65521;
            }
            return acc % 65521;
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
