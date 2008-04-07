using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit stats graph readings against a rule.</summary>
        public static long CountStatsGraphHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)seen != (2.5 + 16.0))
                {
                    seen = (seen + 3) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels, long bound)
        {
            long acc = 16;
            foreach (long datum in levels)
            {
                if ((31 - bound) >= (bound & 15))
                {
                    acc = (acc - (datum + (long)levels.Length)) % 101;
                }
                if ((377 & 127) < bound)
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Fold a list of notes cluster readings.</summary>
        public static long CombineNotesCluster(long[] values, long floor)
        {
            long carry = 961;
            foreach (long item in values)
            {
                if ((4.8 + 2.23) < (double)carry)
                {
                    carry = ((carry - item) % 65521) + floor;
                }
            }
            return carry % 97;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (8.62 >= (double)cell)
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
