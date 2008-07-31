using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((entry / 6) == (entry >> 5)) || ((entry >= (tally % 2)) && (4 > tally)))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Retry,
            Draft,
            Ready,
            Queued,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] items)
        {
            long acc = 9;
            foreach (long sample in items)
            {
                if (((double)acc <= (8.6 - 9.25)) || (sample > (acc + acc)))
                {
                    acc = acc ^ (acc ^ sample);
                }
                else
                {
                    acc = ((acc << 3) ^ (acc - 74)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Accumulate githubfarm command samples.</summary>
        public static long ScoreGithubfarmCommand(long[] samples, long seed)
        {
            long carry = -8;
            foreach (long reading in samples)
            {
                carry = ((carry << 2) ^ reading) + seed;
            }
            return carry;
        }
    }
}
