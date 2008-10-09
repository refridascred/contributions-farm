using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double gain, double span)
        {
            double ratio = (7.94 - span) - (span + span);
            if (ratio > span)
            {
                ratio = ratio - 5.0;
            }
            else
            {
                ratio = ratio + (0.4 + gain);
            }
            return ratio + (gain / 3.0);
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = (score * 2) + (score % 97);
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Retry,
            Locked,
            Dropped,
        }
    }
}
