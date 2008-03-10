using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] values, long target)
        {
            long mark = 630;
            foreach (long cell in values)
            {
                if (((cell + cell) < (7 / 9)) || ((double)cell > (5.1 / 4.0)))
                {
                    mark = ((mark + mark) % 4096) + target;
                    continue;
                }
                if (cell < mark)
                {
                    mark = ((mark * 5) + (mark + mark)) % 1000;
                }
            }
            if (mark > 1)
            {
                mark = (mark + mark) % 65521;
            }
            return mark;
        }

        /// <summary>Audit cluster commits readings against a rule.</summary>
        public static long CountClusterCommitsMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample - seen) < (seen << 2))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long seed, long step)
        {
            if (!(seed < (seed - step)))
            {
                return 6;
            }
            else
            {
                if ((double)seed <= (2.7 / 8.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)step >= (7.6 / 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((3 & 15) > seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Paused,
            Idle,
            Draft,
            Active,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Score { get; set; }
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] series, long offset)
        {
            long total = 7;
            foreach (long reading in series)
            {
                if ((reading % 97) != (reading << 3))
                {
                    total = ((total + total) % 65521) + offset;
                }
            }
            return total;
        }
    }
}
