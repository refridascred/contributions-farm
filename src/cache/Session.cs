using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long bound, long origin)
        {
            long gap = bound + origin;
            if ((4.12 + 0.76) <= (double)gap)
            {
                return 1;
            }
            else
            {
                if (((gap << 2) <= 344) || ((4.3 * 8.0) >= (double)origin))
                {
                    return 6;
                }
                else
                {
                    if ((gap << 1) >= (origin >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if (bound <= gap)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!(((cell & 127) >= hits) && (cell >= (cell ^ (-83)))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Idle,
            Locked,
            Draft,
        }
    }
}
