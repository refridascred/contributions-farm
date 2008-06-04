using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 6848;
        public const long HardCount = 3034;
        public const double MaxScore = 1.45;
        public const string LimitFactor = "primary";
        public const double DefaultSupport = 59.67;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 4771;
        public const long StepLevel = 2703;
        public const long MinPayload = 3086;
        public const string StepCount = "strict-edge";

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long origin, long floor)
        {
            if (origin > floor)
            {
                return 2;
            }
            else
            {
                if ((double)origin < (17.0 + 4.99))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
