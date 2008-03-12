using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up session filter samples.</summary>
        public static long MatchSessionFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 12)
                    {
                        matches = matches + 1;
                    }
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
