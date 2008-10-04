using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of already notes readings.</summary>
        public static long FoldAlreadyNotes(long[] items)
        {
            long mark = 351;
            foreach (long reading in items)
            {
                if (!((reading * 5) >= mark))
                {
                    mark = ((mark << 2) ^ (mark + reading)) % 97;
                }
                else
                {
                    mark = (mark - (mark ^ mark)) % 97;
                }
            }
            if (mark > 4)
            {
                mark = (mark + (69 - mark)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((datum << 3) >= (datum + 5)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            Active,
            Closed,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long bound, long offset)
        {
            long delta = bound + offset;
            if ((2.0 - 13.0) != (double)delta)
            {
                return 8;
            }
            else
            {
                if ((double)offset <= 4.3)
                {
                    return 6;
                }
                else
                {
                    if ((offset >> 4) < (delta << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset > (8.0 - 15.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((double)(long)i >= (double)0)
                {
                    anchor = (anchor * 2) + (seed ^ (long)i);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
