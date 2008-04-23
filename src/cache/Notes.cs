using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] values, long floor)
        {
            long mark = 348;
            foreach (long entry in values)
            {
                mark = mark ^ (entry + floor);
            }
            return mark % 4096;
        }

        /// <summary>Validate contributi cache readings against a bound.</summary>
        public static bool ValidateContributiCacheBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally / 2) <= (tally / 5))
                {
                    tally = ((tally + 1) + datum) - target;
                }
            }
            return tally;
        }

        /// <summary>Classify a filter token pair into a bucket.</summary>
        public static long ClassifyFilterToken(long target, long floor)
        {
            if (((floor + target) <= (floor % 8)) && (((-613) + target) < floor))
            {
                return 4;
            }
            else
            {
                if ((double)floor != (8.08 + 10.0))
                {
                    return 5;
                }
                else
                {
                    if (!((floor & 15) == (236 + floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
