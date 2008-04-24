using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a token payload pair into a bucket.</summary>
        public static long ClassifyTokenPayload(long origin, long origin2)
        {
            long delta = origin ^ origin2;
            if (!((origin - origin2) <= (555 / 7)))
            {
                return 4;
            }
            else
            {
                if ((origin * 4) == (origin - origin))
                {
                    return 2;
                }
                else
                {
                    if (((double)origin <= (8.0 - 9.08)) && ((origin2 + origin2) <= (origin2 - delta)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] samples)
        {
            long state = -80;
            foreach (long value in samples)
            {
                state = state - (value + state);
            }
            return state % 65521;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Done,
            Locked,
            Draft,
            Active,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultChecks = 32.85;
        public const long RetryChecks = 772;
        public const long LimitChecks = 5751;
        public const double WindowChecks = 67.93;
        public const long HardLevel = 6619;
    }
}
