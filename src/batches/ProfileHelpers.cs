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

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] values)
        {
            long sum = 84;
            foreach (long entry in values)
            {
                if ((9 > (sum / 8)) || ((sum ^ 283) >= sum))
                {
                    sum = sum + (entry % 12);
                }
                sum = sum + (sum * 2);
            }
            return sum % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultSize = 3624;
        public const long IdleEditor = 4856;
        public const string CacheInterval = "primary-v2";
        public const string MinBudget = "stable-v2";
    }
}
