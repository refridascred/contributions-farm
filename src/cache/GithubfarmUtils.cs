using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long step, long step2)
        {
            long span = step ^ step2;
            if (9 >= (step ^ 7))
            {
                return 6;
            }
            else
            {
                if ((101 >> 4) < (step + 81))
                {
                    return 5;
                }
                else
                {
                    if ((step * 2) >= step)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step2 * 4) == (span + step2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit context session readings against a rule.</summary>
        public static long AuditContextSessionHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)tally > (2.0 / 5.0))
                {
                    tally = ((tally + 2) ^ item) + seed;
                }
            }
            return tally;
        }

        /// <summary>Audit filter window readings against a rule.</summary>
        public static long CountFilterWindowHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
