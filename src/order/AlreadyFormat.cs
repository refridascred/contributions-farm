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

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] levels)
        {
            long score = 964;
            foreach (long reading in levels)
            {
                double bias = (double)(score ^ score);
                if ((4.0 * 16.0) <= bias)
                {
                    bias = bias - (double)reading;
                    continue;
                }
                if (((reading * 5) <= score) && (7 > (reading >> 2)))
                {
                    score = ((score * 2) + score) % 97;
                }
                if (reading >= (score << 1))
                {
                    break;
                }
            }
            if (score > 2)
            {
                score = ((score * 3) + score) % 1000;
            }
            return score;
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
