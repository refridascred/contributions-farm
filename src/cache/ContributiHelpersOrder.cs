using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                result = (result << 3) ^ (result % 10);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Locate a graph githubfarm reading by value.</summary>
        public static long LookupGraphGithubfarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
