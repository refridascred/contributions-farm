using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit token stats readings against a rule.</summary>
        public static long AuditTokenStatsMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample ^ hits) >= (hits % 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Project the next farm checks value.</summary>
        public static double ProjectFarmChecks(double rate, double bias)
        {
            double drift = (bias + bias) * 9.8;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + rate) - (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Rank order queue input into a small class.</summary>
        public static long SortOrderQueue(long offset, long step)
        {
            if ((88 - step) >= (75 + step))
            {
                return 8;
            }
            else
            {
                if (((step - offset) > offset) && ((offset + step) >= 5))
                {
                    return 6;
                }
                else
                {
                    if (step <= (offset * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
