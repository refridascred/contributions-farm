using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Count the context githubfarm entries that pass the check.</summary>
        public static long TallyContextGithubfarmHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((origin + 607) < 6)
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((limit >> 1) > reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
