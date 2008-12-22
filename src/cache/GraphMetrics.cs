using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long seed, long bound)
        {
            long span = seed - bound;
            if ((3.4 - 19.0) <= (double)seed)
            {
                return 3;
            }
            else
            {
                if (9 <= (span + span))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed >= (20.0 * 12.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((80 + 57) < bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((((double)reading >= (3.0 + 16.0)) || ((double)reading <= 11.0)) || ((0 + reading) < (matches - matches)))
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

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Queued,
            Done,
            Draft,
        }
    }
}
