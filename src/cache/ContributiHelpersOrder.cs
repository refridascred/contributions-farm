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

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double rate, double span)
        {
            double ratio = (double)(442 + 983);
            if (ratio < (span + rate))
            {
                ratio = ratio - (ratio * 12.0);
            }
            return ratio - rate;
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
