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

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
