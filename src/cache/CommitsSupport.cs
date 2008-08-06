using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)item <= (6.2 + 13.0))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] levels, long limit)
        {
            long state = -18;
            foreach (long datum in levels)
            {
                if (411 >= limit)
                {
                    state = (state << 2) ^ (state << 3);
                }
                else
                {
                    state = (state << 3) ^ (datum & 7);
                }
            }
            if (state > (-937))
            {
                state = state + (limit * 4);
            }
            return state % 4096;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] series)
        {
            long acc = 19;
            foreach (long entry in series)
            {
                if (885 <= (entry << 3))
                {
                    acc = (acc + (87 / 7)) % 101;
                }
                if ((acc + 37) != (acc ^ 743))
                {
                    acc = acc ^ (entry * 5);
                }
            }
            return acc;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] readings, long seed)
        {
            long result = 9;
            foreach (long datum in readings)
            {
                if ((seed ^ seed) <= (result + datum))
                {
                    result = (result ^ ((long)readings.Length / 6)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Count { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
