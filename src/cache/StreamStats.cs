using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Size { get; set; }
            public bool Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double gain, double offset)
        {
            double weight = offset;
            if (weight < (double)508)
            {
                weight = (weight - (double)40) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - offset) - (double)(long)i;
            }
            return weight + (weight / 7.0);
        }

        /// <summary>Roll a token window counter forward.</summary>
        public static long SeriesTokenWindow(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor - (step & 7)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public long Count { get; set; }
        }
    }
}
