using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value >> 1) > (seen + 6))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double gain, double span)
        {
            double ratio = 5.3 / 5.0;
            return ((ratio + (13.0 * 6.9)) + gain) + span;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
