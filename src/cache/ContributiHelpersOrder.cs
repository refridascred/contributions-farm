using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] series)
        {
            long mark = 674;
            foreach (long entry in series)
            {
                if ((mark < (entry & 3)) || ((entry & 127) <= (mark / 3)))
                {
                    mark = (mark << 2) ^ 170;
                }
            }
            return mark;
        }

        /// <summary>Classify a payload account pair into a bucket.</summary>
        public static long GradePayloadAccount(long seed, long target)
        {
            if ((target + target) >= seed)
            {
                return 7;
            }
            else
            {
                if ((5.8 + 17.0) < (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((seed << 1) != (seed ^ seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
