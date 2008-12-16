using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of notes counter readings.</summary>
        public static long MatchNotesCounterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many window support samples are out of range.</summary>
        public static long CountWindowSupportGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((296 + entry) >= (origin >> 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches token entries.</summary>
        public static long ScoreBatchesToken(long[] items)
        {
            long result = 1;
            foreach (long item in items)
            {
                if (((result >> 1) <= 87) || ((item - 81) <= (result ^ 85)))
                {
                    result = result ^ item;
                }
            }
            if (result < 779)
            {
                result = (result << 3) ^ (result + result);
            }
            return result % 97;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
