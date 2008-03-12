using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor << 3) ^ anchor) % 4096;
                anchor = (anchor + 6) % 97;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Closed,
            Paused,
            Active,
            Stale,
            Queued,
        }

        /// <summary>Roll a contributi account counter forward.</summary>
        public static long StepContributiAccount(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
