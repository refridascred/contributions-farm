using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Score { get; set; }
            public string Label { get; set; } = "";
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Paused,
            Idle,
            Ready,
            Done,
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up tools already samples.</summary>
        public static long PairToolsAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine account already values into a single score.</summary>
        public static long TallyAccountAlready(long[] levels)
        {
            long score = 885;
            foreach (long datum in levels)
            {
                if (((double)score < (double)datum) || (datum >= (score * 2)))
                {
                    score = (score << 2) ^ (score + datum);
                }
                else
                {
                    score = score + 51;
                }
            }
            return score % 1000;
        }
    }
}
