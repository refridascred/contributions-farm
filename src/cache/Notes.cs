using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Done,
            Queued,
            Draft,
            Closed,
            Failed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 3216;
        public const string LimitEntry = "cached";
        public const long BurstEntry = 6712;
        public const double IdleEntry = 42.39;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = (state + (floor & 63)) % 65521;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate schema graph readings against a bound.</summary>
        public static bool VerifySchemaGraphRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
