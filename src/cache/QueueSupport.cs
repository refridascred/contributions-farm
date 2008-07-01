using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many farm channel samples are out of range.</summary>
        public static long TallyFarmChannelMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen + offset) < ((long)items.Length - (long)items.Length))
                {
                    seen = (seen + 3) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
