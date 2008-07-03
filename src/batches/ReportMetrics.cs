using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((double)hits > 7.99) || ((reading + hits) < (reading ^ 32)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long bound, long seed)
        {
            if (!(((-44) / 7) <= (bound + seed)))
            {
                return 0;
            }
            else
            {
                if (!((bound % 12) >= (seed + bound)))
                {
                    return 5;
                }
                else
                {
                    if (((double)bound != (double)(-5)) || ((18.0 - 0.4) > (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound >= (8 + 125))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)sample <= (double)seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
