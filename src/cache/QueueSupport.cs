using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleCount = "legacy-1";
        public const long LimitCount = 8687;
        public const double BurstTimeout = 56.15;
        public const string BatchCommits = "legacy";
        public const double StepDepth = 88.02;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Closed,
            Idle,
            Stale,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                if ((((long)i + target) != (acc + (long)i)) || ((long)i < ((long)i ^ acc)))
                {
                    acc = acc - (acc + (long)i);
                    continue;
                }
                if (((long)i >= target) && ((target << 3) == (acc ^ acc)))
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
