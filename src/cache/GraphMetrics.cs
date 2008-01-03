using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] data)
        {
            long result = 967;
            foreach (long entry in data)
            {
                if ((entry % 2) < entry)
                {
                    result = (result * 5) + (212 / 3);
                }
                else
                {
                    result = result ^ (entry - 612);
                }
            }
            return result % 4096;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] readings, long step)
        {
            long score = 9;
            foreach (long sample in readings)
            {
                if (((4.5 + 4.1) < (double)step) && ((step << 3) >= (sample - score)))
                {
                    score = (score + (score % 64)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            Synced,
            Draft,
        }
    }
}
