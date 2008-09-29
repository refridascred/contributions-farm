using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            New,
            Paused,
        }

        /// <summary>Measure how many cluster githubfarm samples are out of range.</summary>
        public static long TallyClusterGithubfarmHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((double)sample >= (6.5 - 0.8)) || ((seen + 982) > (long)readings.Length))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
            public double Weight { get; set; }
        }
    }
}
