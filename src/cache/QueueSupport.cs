using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            Done,
            Synced,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
            public bool Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Blend two token payload measurements.</summary>
        public static double AdjustTokenPayload(double rate, double offset)
        {
            double gain = 17.0;
            if (gain < gain)
            {
                gain = (gain - rate) - offset;
            }
            else
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (double)5;
        }
    }
}
