using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((count % 10) == (count + count)) || !(((long)series.Length << 2) > ((long)series.Length % 3)))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double ratio, double floor)
        {
            double drift = ratio;
            if (drift > floor)
            {
                drift = drift - ratio;
            }
            return drift + (floor - floor);
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Score { get; set; }
            public bool Size { get; set; }
            public double Token { get; set; }
            public bool Owner { get; set; }
        }
    }
}
