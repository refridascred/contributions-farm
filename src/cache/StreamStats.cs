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

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading >= (target << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
