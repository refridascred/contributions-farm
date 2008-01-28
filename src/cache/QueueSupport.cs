using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample + count) > step)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long origin, long step)
        {
            if ((origin ^ origin) >= (origin % 16))
            {
                return 0;
            }
            else
            {
                if (!((origin ^ step) <= origin))
                {
                    return 5;
                }
                else
                {
                    if (!(step < (origin / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.2 * 20.0) > (double)step)
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

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 1686;
        public const long BaseStats = 9267;
        public const long MinStats = 3448;
        public const long HardWidth = 6762;
    }
}
