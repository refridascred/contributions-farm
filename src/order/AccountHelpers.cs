using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long step)
        {
            long mix = step;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix << 3) ^ (step / 3)) % 4096;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Closed,
            Ready,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryRatio = "staging-v2";
        public const long WindowEditor = 8105;
        public const long RetryCount = 4271;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 5434;
        public const long IdleInterval = 8591;
        public const long LimitCluster = 9197;
        public const long HardCluster = 8205;

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double rate, double floor)
        {
            double load = (double)(150 + 3);
            if (load >= (double)50)
            {
                load = load + (double)94;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((401 << 3) < (matches - (-8)))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }
    }
}
