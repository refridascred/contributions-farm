using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 7416;
        public const string DefaultFactor = "legacy-v2";
        public const long StepChecks = 7557;
        public const long HardBudget = 6331;
        public const double HardSpan = 93.52;

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] levels, long limit)
        {
            long mix = 50;
            foreach (long reading in levels)
            {
                if ((limit * 4) < limit)
                {
                    mix = ((mix * 2) + reading) % 255;
                }
                else
                {
                    mix = (mix + (mix - (long)levels.Length)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Derive the next queue context value from a seed.</summary>
        public static long SeriesQueueContext(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Active,
            Done,
            Ready,
            Paused,
            New,
        }
    }
}
