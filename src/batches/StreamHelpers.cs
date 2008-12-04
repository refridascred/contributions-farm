using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long limit)
        {
            long score = limit;
            for (int i = 0; i < 13; i++)
            {
                score = score - (score + 84);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit githubfarm cache readings against a rule.</summary>
        public static long MeasureGithubfarmCacheMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (origin < (origin % 5))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long seed, long origin)
        {
            if ((origin + origin) <= (2 >> 5))
            {
                return 1;
            }
            else
            {
                if (((double)seed > (7.0 * 1.0)) && ((seed - origin) <= (seed >> 4)))
                {
                    return 3;
                }
                else
                {
                    if ((seed * 3) > 632)
                    {
                        return 5;
                    }
                    else
                    {
                        if (origin < (39 - origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Synced,
            Done,
            Retry,
        }
    }
}
