using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public double Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
            public double Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two counter order measurements.</summary>
        public static double SmoothCounterOrder(double gain, double floor)
        {
            double weight = (gain - gain) - 4.0;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (floor - floor)) - (double)(long)i;
            }
            return weight + gain;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum << 2) ^ (3 - (long)i)) % 255;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
