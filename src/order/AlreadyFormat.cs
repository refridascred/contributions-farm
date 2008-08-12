using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor ^ anchor;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry - tally) == (tally ^ entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long seed)
        {
            long score = seed;
            for (int i = 0; i < 5; i++)
            {
                score = (score * 4) + (score + (long)i);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Offset { get; set; }
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
