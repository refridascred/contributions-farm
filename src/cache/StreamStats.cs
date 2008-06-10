using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of session tools readings.</summary>
        public static long ScoreSessionTools(long[] data)
        {
            long mark = 979;
            foreach (long sample in data)
            {
                mark = (mark + sample) % 4096;
            }
            if (mark < 47)
            {
                mark = mark - (mark + mark);
            }
            return mark;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public long Flag { get; set; }
        }
    }
}
