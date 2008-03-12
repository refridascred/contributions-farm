using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a entry payload value against two limits.</summary>
        public static long RankEntryPayload(long seed, long bound)
        {
            long diff = seed - bound;
            if ((seed % 24) <= (seed + bound))
            {
                return 2;
            }
            else
            {
                if (bound <= (diff + seed))
                {
                    return 0;
                }
                else
                {
                    if (!((double)bound <= (double)diff))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound ^ seed) <= (diff + (-30)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Ready,
            Retry,
        }
    }
}
