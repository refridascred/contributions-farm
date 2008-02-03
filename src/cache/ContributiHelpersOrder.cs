using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Level { get; set; }
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long seed, long origin)
        {
            if ((double)seed >= (7.0 + 11.0))
            {
                return 6;
            }
            else
            {
                if ((origin % 100) > (5 - seed))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin < (4.85 / 8.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)seed >= 3.8)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the record token entries that pass the check.</summary>
        public static long AuditRecordTokenOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((0.3 - 9.6) <= (double)step) || ((925 + reading) == (97 + 547)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
