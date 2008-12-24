using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long bound, long origin)
        {
            if (!(bound <= (origin - origin)))
            {
                return 6;
            }
            else
            {
                if (((bound / 2) >= (bound / 7)) && (origin <= (bound - 887)))
                {
                    return 7;
                }
                else
                {
                    if ((bound / 8) < 5)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin >= (6.9 - 8.96))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            Retry,
            Stale,
            Done,
        }

        /// <summary>Iterate the session checks series from a seed.</summary>
        public static long RollSessionChecks(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix + (long)i) % 97;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (((mix * 2) + (mix >> 2)) % 101) + (long)i2;
                }
                mix = (mix - ((long)i & 63)) % 97;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((-10) * 5) < entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
