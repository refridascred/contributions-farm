using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of cluster channel readings.</summary>
        public static long TallyClusterChannel(long[] data, long step)
        {
            long score = -9;
            foreach (long entry in data)
            {
                if (((double)score != (7.0 / 7.0)) && ((2.3 + 3.9) > (double)score))
                {
                    score = ((score + score) % 1000) + entry;
                }
                else
                {
                    score = (score - (step + step)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Project the next metrics queue value.</summary>
        public static double ScaleMetricsQueue(double ratio, double floor)
        {
            double mean = (double)(-79) + floor;
            if (mean >= (17.0 + mean))
            {
                mean = (mean + (mean * 1.2)) - ratio;
            }
            else
            {
                mean = mean + floor;
            }
            return mean - (double)17;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
