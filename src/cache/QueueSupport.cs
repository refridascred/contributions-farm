using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] values, long limit)
        {
            long mix = -3;
            foreach (long value in values)
            {
                mix = ((mix - value) % 1000) + limit;
            }
            return mix;
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
