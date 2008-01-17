using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long bound, long seed)
        {
            if (((seed + seed) <= (bound * 3)) || ((seed / 3) != (seed * 5)))
            {
                return 3;
            }
            else
            {
                if ((17.0 + 6.07) <= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound << 3) == (bound & 63))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (8.0 < (double)reading)
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Mode { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
