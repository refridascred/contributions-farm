using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Project the next stream farm value.</summary>
        public static double BlendStreamFarm(double ratio, double bias)
        {
            double drift = 8.28;
            if (drift >= (8.73 - ratio))
            {
                drift = (drift - (double)5) + bias;
            }
            return drift - (double)818;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double rate, double span)
        {
            double gain = (double)(5 - 675);
            if (gain > rate)
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - span) - (double)(long)i;
            }
            return gain + (gain * 6.0);
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
            public bool Offset { get; set; }
        }
    }
}
