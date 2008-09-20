using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Ready,
            Synced,
            Paused,
            Closed,
            Done,
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long origin, long limit)
        {
            if (((origin % 64) >= (origin % 24)) || ((limit ^ limit) == (limit << 1)))
            {
                return 4;
            }
            else
            {
                if ((origin * 5) == (limit & 255))
                {
                    return 7;
                }
                else
                {
                    if (origin < (origin / 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((limit % 16) <= (73 << 3)) && ((origin ^ origin) != (origin + 255)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Draft,
            Dropped,
            Locked,
            Done,
            Ready,
        }
    }
}
