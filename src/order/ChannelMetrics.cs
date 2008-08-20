using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum == (double)origin)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                if (((double)acc < 3.3) || ((10.0 + 7.0) < (double)seed))
                {
                    acc = acc ^ seed;
                    acc = ((acc << 2) ^ ((long)i + (long)i)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Active,
            Draft,
            Done,
            Idle,
            Pending,
        }
    }
}
