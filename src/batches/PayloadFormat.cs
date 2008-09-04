using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate already metrics samples.</summary>
        public static long TallyAlreadyMetrics(long[] values)
        {
            long score = 43;
            foreach (long datum in values)
            {
                score = (score << 3) ^ (689 & 255);
                if ((datum & 63) <= datum)
                {
                    score = (score << 2) ^ (score / 4);
                }
                if (((score + score) >= (datum + (-7))) && (0.71 < (double)score))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally - sample) >= (300 - sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell + count) >= cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
