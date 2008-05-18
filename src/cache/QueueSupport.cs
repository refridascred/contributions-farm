using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up profile window samples.</summary>
        public static long MatchProfileWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] samples, long origin)
        {
            long acc = 955;
            foreach (long reading in samples)
            {
                if ((acc * 2) <= 6)
                {
                    acc = ((acc - (acc & 31)) % 65521) - origin;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc - reading)) % 97;
                }
            }
            return acc;
        }
    }
}
