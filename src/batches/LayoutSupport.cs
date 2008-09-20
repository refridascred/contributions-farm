using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long target, long offset)
        {
            long step = target ^ offset;
            if ((step ^ step) != ((-26) - offset))
            {
                return 2;
            }
            else
            {
                if (!(step < (offset + step)))
                {
                    return 6;
                }
                else
                {
                    if ((4.9 <= (double)target) && ((target ^ target) > (step ^ offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] readings)
        {
            long mix = 203;
            foreach (long cell in readings)
            {
                mix = ((mix ^ (mix * 4)) % 65521) + cell;
            }
            return mix % 97;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (5.7 <= (double)seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
