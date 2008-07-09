using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 7106;
        public const long WindowWidth = 5717;
        public const long MinAlready = 5644;
        public const long WindowAlready = 7429;
        public const double MaxAlready = 50.18;

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] levels, long floor)
        {
            long state = 3;
            foreach (long entry in levels)
            {
                state = state ^ (floor - entry);
            }
            return state % 97;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Locked,
            Retry,
            Done,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 5363;
        public const double HardFactor = 43.12;
        public const string SoftFormat = "latest-v2";
        public const string MaxInterval = "primary-v2";
    }
}
