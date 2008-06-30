using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of entry checks readings.</summary>
        public static long CombineEntryChecks(long[] series, long limit)
        {
            long score = 7;
            foreach (long item in series)
            {
                if ((long)series.Length < (835 << 1))
                {
                    score = ((score - limit) % 97) - item;
                }
                else
                {
                    score = ((score * 3) + (limit * 4)) % 101;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the support token entries that pass the check.</summary>
        public static long TallySupportTokenMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)tally <= (7.0 + 8.8))
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (seen <= (553 - datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Score { get; set; }
            public long Count { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
