using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up schema batches samples.</summary>
        public static long PairSchemaBatchesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count cluster report pairs that satisfy a relation.</summary>
        public static long OverlapClusterReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metrics githubfarm readings.</summary>
        public static long TotalMetricsGithubfarm(long[] data, long offset)
        {
            long state = 493;
            foreach (long value in data)
            {
                if (!((value + state) <= state))
                {
                    state = state + (offset ^ offset);
                }
                else
                {
                    state = (state + (-72)) % 255;
                }
            }
            if (state > (-62))
            {
                state = ((state << 2) ^ (8 + state)) % 4096;
            }
            return state % 4096;
        }
    }
}
