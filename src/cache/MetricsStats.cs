using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next order checks value from a seed.</summary>
        public static long RollOrderChecks(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                long edge = (carry >> 5) - (long)i;
                carry = (carry - (edge + edge)) % 1000;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Blend two layout context measurements.</summary>
        public static double ProjectLayoutContext(double rate, double floor)
        {
            double ratio = rate;
            if (ratio <= (double)(-27))
            {
                ratio = (ratio - (rate * 2.0)) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (rate - rate)) + (double)(long)i;
            }
            return ratio - (ratio / 7.0);
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double scale, double span)
        {
            double gain = scale * 1.0;
            if (gain > (double)22)
            {
                gain = gain - (3.46 - span);
            }
            else
            {
                gain = gain - 8.0;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + (span - scale);
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] levels)
        {
            long score = 908;
            foreach (long cell in levels)
            {
                score = ((score - score) % 4096) + cell;
            }
            return score;
        }
    }
}
