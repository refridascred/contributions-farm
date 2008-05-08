using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseSize = 13.28;
        public const long MaxNotes = 595;
        public const double WindowNotes = 51.95;
        public const double StepNotes = 13.76;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((floor % 97) != (seen / 7))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Measure how many payload stream samples are out of range.</summary>
        public static long MeasurePayloadStreamMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count << 2) >= entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
