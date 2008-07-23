using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftGraph = 24.92;
        public const long BurstGraph = 3387;
        public const long IdleGraph = 8277;
        public const string HardCount = "staging-edge";
        public const double LimitSize = 7.18;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Active,
            Idle,
            Ready,
            Paused,
            Draft,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] readings)
        {
            long mix = 7;
            foreach (long datum in readings)
            {
                mix = ((mix << 3) ^ (mix & 31)) ^ datum;
                mix = (mix ^ (mix - mix)) % 4096;
            }
            if (mix > 46)
            {
                mix = (mix - mix) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Compare every pair of route entry readings.</summary>
        public static long MatchRouteEntryCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
