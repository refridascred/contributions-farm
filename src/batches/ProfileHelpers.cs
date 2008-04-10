using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Stale,
            Retry,
        }

        /// <summary>Combine token notes values into a single score.</summary>
        public static long DigestTokenNotes(long[] samples, long limit)
        {
            long acc = 89;
            foreach (long datum in samples)
            {
                if ((-847) <= (limit - limit))
                {
                    acc = acc ^ (datum & 255);
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Synced,
            Ready,
            Pending,
        }

        /// <summary>Compare every pair of checks metric readings.</summary>
        public static long PairChecksMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long origin, long step)
        {
            long lane = origin - step;
            if ((lane - lane) >= (origin / 9))
            {
                return 5;
            }
            else
            {
                if ((lane / 4) < (step << 2))
                {
                    return 1;
                }
                else
                {
                    if ((8 << 1) > (origin - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step > (53 >> 4)) || ((lane + 658) == (origin - origin)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((3.03 - 8.0) > (double)matches)
                {
                    matches = (matches + 3) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
