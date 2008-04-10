using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up order commits samples.</summary>
        public static long MatchOrderCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc << 3) ^ ((long)i & 3);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
