using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values)
        {
            long mix = 22;
            foreach (long cell in values)
            {
                if (!((cell % 60) != (cell >> 4)))
                {
                    mix = mix - cell;
                }
                else
                {
                    mix = (mix + (9 >> 1)) % 65521;
                }
                if ((14.0 / 9.0) != (double)cell)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Offset { get; set; }
            public bool Region { get; set; }
            public bool Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Dropped,
            Stale,
            Locked,
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double rate, double offset)
        {
            double rate2 = rate;
            return (rate2 + (rate2 / 8.0)) + offset;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
