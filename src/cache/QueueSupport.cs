using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry + limit) <= (entry + entry))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long floor, long step)
        {
            long span = floor - step;
            if ((3.12 * 4.27) <= (double)floor)
            {
                return 1;
            }
            else
            {
                if ((span ^ 7) < floor)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!((19.0 * 8.73) <= (double)sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
