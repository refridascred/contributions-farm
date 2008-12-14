using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((long)series.Length < item)
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long bound, long seed)
        {
            if ((bound & 7) == (bound / 7))
            {
                return 0;
            }
            else
            {
                if (seed < (bound / 4))
                {
                    return 7;
                }
                else
                {
                    if (((seed + seed) != (bound << 3)) || ((seed & 7) != (bound + bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the cluster account entries that pass the check.</summary>
        public static long MeasureClusterAccountGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((long)readings.Length + item) > 8)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate already githubfarm samples.</summary>
        public static long WeighAlreadyGithubfarm(long[] values, long bound)
        {
            long mark = 57;
            foreach (long cell in values)
            {
                if ((cell - cell) < (cell ^ bound))
                {
                    break;
                }
                mark = mark ^ cell;
            }
            return mark;
        }
    }
}
