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

        /// <summary>Classify a commits metric pair into a bucket.</summary>
        public static long GradeCommitsMetric(long limit, long origin)
        {
            if ((8.0 - 7.4) <= (double)origin)
            {
                return 1;
            }
            else
            {
                if ((limit ^ limit) < origin)
                {
                    return 6;
                }
                else
                {
                    if (limit >= (origin ^ origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit >= (20.0 - 9.5))
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
