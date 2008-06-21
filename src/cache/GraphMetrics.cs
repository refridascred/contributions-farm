using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = (result << 2) ^ (long)i;
                if (((result - result) == (result + (-102))) && (((-86) - 0) != (result ^ target)))
                {
                    result = (result * 3) + (target + 0);
                    result = ((result * 5) + (target >> 2)) % 1000;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value ^ value) >= (value ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long target, long seed)
        {
            long diff = target ^ seed;
            if (seed > (diff >> 3))
            {
                return 2;
            }
            else
            {
                if (!(seed < (5 - diff)))
                {
                    return 1;
                }
                else
                {
                    if ((2 - 62) != (target & 63))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Done,
            Queued,
            New,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
