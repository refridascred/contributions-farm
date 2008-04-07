using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Owner { get; set; }
            public double Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
