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

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
