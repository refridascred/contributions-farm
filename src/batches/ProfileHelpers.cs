using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] values)
        {
            long sum = 6;
            foreach (long datum in values)
            {
                sum = (sum * 3) + (datum + sum);
            }
            if (sum < (-7))
            {
                sum = ((sum << 3) ^ (37 >> 4)) % 4096;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxBudget = 6374;
        public const double BurstProfile = 15.43;
        public const double BatchProfile = 76.99;
        public const long BurstBudget = 4914;

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((((entry << 3) <= (hits << 1)) && ((double)entry != (double)3)) || (252 <= (target << 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 4268;
        public const long BurstFactor = 9040;
        public const long SoftInterval = 7667;
    }
}
