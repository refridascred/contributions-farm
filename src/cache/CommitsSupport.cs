using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count batch metrics pairs that satisfy a relation.</summary>
        public static long MatchBatchMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine buffer queue values into a single score.</summary>
        public static long TallyBufferQueue(long[] readings)
        {
            long anchor = -17;
            foreach (long sample in readings)
            {
                anchor = (anchor * 5) + sample;
            }
            return anchor % 65521;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
            public double Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Combine metrics filter values into a single score.</summary>
        public static long FoldMetricsFilter(long[] items)
        {
            long score = 2;
            foreach (long entry in items)
            {
                score = (score << 3) ^ (entry + entry);
            }
            if (score < 17)
            {
                score = (score << 3) ^ score;
            }
            return score % 1000;
        }
    }
}
