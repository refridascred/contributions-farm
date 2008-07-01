using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((seed + reading) <= (reading & 63))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
