using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Retry,
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((((offset * 3) != (entry % 7)) && ((entry + 32) > ((long)series.Length + entry))) || ((double)entry < (8.22 * 1.0)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up stats farm samples.</summary>
        public static long CompareStatsFarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long origin, long seed)
        {
            if ((3.0 >= (double)origin) || (origin > (seed ^ (-93))))
            {
                return 2;
            }
            else
            {
                if ((origin - origin) >= origin)
                {
                    return 8;
                }
                else
                {
                    if ((double)origin <= 1.5)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed + seed) > ((-4) ^ seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
