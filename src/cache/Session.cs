using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark + (long)i) % 97;
                mark = (mark - step) % 65521;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every checks batch entry stays within the limit.</summary>
        public static bool CheckChecksBatchRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
        }
    }
}
