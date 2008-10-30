using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long offset, long offset2)
        {
            if (((-92) ^ offset2) >= offset)
            {
                return 0;
            }
            else
            {
                if (!((offset % 97) >= (6 >> 2)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((2.2 / 5.0) > (double)tally)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
