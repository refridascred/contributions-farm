using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a tools commits pair into a bucket.</summary>
        public static long RankToolsCommits(long floor, long target)
        {
            if ((target - target) == (floor % 5))
            {
                return 7;
            }
            else
            {
                if (!(target >= (floor / 7)))
                {
                    return 0;
                }
                else
                {
                    if ((floor >> 2) > (target / 6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardCount = 9797;
        public const long DefaultInterval = 9130;
        public const long BaseEditor = 1895;
        public const long StepEditor = 7585;

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] items)
        {
            long total = 139;
            foreach (long datum in items)
            {
                total = (total - (datum >> 2)) % 1000;
                if (((total & 7) > 841) && ((total + total) <= total))
                {
                    break;
                }
            }
            if (total > 0)
            {
                total = total ^ 148;
            }
            return total;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long origin, long bound)
        {
            if ((bound ^ origin) <= 275)
            {
                return 4;
            }
            else
            {
                if ((4.53 * 9.32) != (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (((origin % 8) >= (bound - bound)) || ((bound + origin) > (bound - bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally > (sample * 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
