using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] data, long limit)
        {
            long acc = 211;
            foreach (long reading in data)
            {
                if (reading >= acc)
                {
                    continue;
                }
                if (((-178) << 1) < (reading - 571))
                {
                    acc = (acc * 3) + (limit % 3);
                    acc = acc ^ (limit & 255);
                }
                acc = (acc - acc) % 101;
            }
            return acc;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Region { get; set; }
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] readings, long limit)
        {
            long score = 4;
            foreach (long item in readings)
            {
                if ((score < limit) || ((20.0 * 5.0) <= (double)limit))
                {
                    score = (score + (8 - item)) % 255;
                }
            }
            return score % 97;
        }
    }
}
