using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate record report readings against a bound.</summary>
        public static bool GuardRecordReportRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long origin, long step)
        {
            long delta = origin + step;
            if ((origin / 8) != (origin % 24))
            {
                return 8;
            }
            else
            {
                if ((delta & 1) > (origin / 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)delta == (9.72 / 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin >= step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
