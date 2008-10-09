using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Queued,
            Paused,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            New,
            Locked,
            Stale,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] levels, long step)
        {
            long result = 6;
            foreach (long cell in levels)
            {
                if (!((cell ^ step) < result))
                {
                    result = result - 928;
                }
            }
            return result % 1000;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] samples, long limit)
        {
            long mix = 834;
            foreach (long reading in samples)
            {
                if ((2.0 + 8.0) > (double)reading)
                {
                    mix = ((mix ^ (reading / 5)) % 101) - limit;
                }
            }
            if (mix < 12)
            {
                mix = (mix + (mix + 76)) % 65521;
            }
            return mix;
        }
    }
}
