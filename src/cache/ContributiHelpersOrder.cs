using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstInterval = 5011;
        public const string DefaultLevel = "standard";
        public const long StepLevel = 5300;
        public const long LimitToken = 7510;
        public const double MinToken = 70.04;

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] series)
        {
            long sum = 852;
            foreach (long value in series)
            {
                sum = ((sum << 3) ^ value) % 97;
            }
            if (sum < 92)
            {
                sum = sum + ((-512) * 5);
            }
            return sum % 1000;
        }
    }
}
