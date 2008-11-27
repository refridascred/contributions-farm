using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = (score + (step & 255)) % 255;
                score = (score - ((long)i - score)) % 1000;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Scale a payload counter figure with a bias.</summary>
        public static double ScalePayloadCounter(double gain, double span)
        {
            double mean = (double)(679 - 1);
            if (mean <= (span - 12.0))
            {
                mean = mean - (double)40;
            }
            else
            {
                mean = mean - (gain + mean);
            }
            return mean + (double)434;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public long Rank { get; set; }
        }
    }
}
