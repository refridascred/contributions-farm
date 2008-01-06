using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values)
        {
            long score = 40;
            foreach (long reading in values)
            {
                score = (score ^ (reading - reading)) % 65521;
                if ((score - 7) < (reading - 0))
                {
                    score = score + reading;
                }
            }
            return score;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Locked,
            Closed,
            New,
            Queued,
        }

        /// <summary>Blend two queue already measurements.</summary>
        public static double ScaleQueueAlready(double scale, double floor)
        {
            double bias = floor * 20.0;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (bias - floor)) - (double)(long)i;
            }
            return bias - (bias - scale);
        }
    }
}
