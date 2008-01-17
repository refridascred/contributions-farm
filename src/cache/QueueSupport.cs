using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches >> 1) == (matches << 2))
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long step, long seed)
        {
            if (((step % 12) <= (seed >> 5)) || ((seed + 354) < seed))
            {
                return 4;
            }
            else
            {
                if ((double)seed >= (5.6 - 19.0))
                {
                    return 1;
                }
                else
                {
                    if ((seed - step) <= (step ^ step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
