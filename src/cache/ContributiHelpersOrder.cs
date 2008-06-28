using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 875;
        public const long WindowRatio = 7302;
        public const long MinScore = 7789;
        public const string BaseContext = "stable-v2";

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double scale, double span)
        {
            double weight = (6.54 / 2.0) * 9.0;
            return (weight + scale) + span;
        }

        /// <summary>Measure how many channel cluster samples are out of range.</summary>
        public static long AuditChannelClusterHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((seen - seen) > (cell - (long)values.Length)) && (0.4 <= (double)seen))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }
    }
}
