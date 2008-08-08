using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of queue counter readings.</summary>
        public static long OverlapQueueCounterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((((seed & 15) > (reading / 3)) || ((double)hits >= (2.5 - 6.5))) && ((seed / 3) >= (hits - seed)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a channel metrics counter forward.</summary>
        public static long StepChannelMetrics(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultSize = 3624;
        public const long IdleEditor = 4856;
        public const string CacheInterval = "primary-v2";
        public const string MinBudget = "stable-v2";
    }
}
