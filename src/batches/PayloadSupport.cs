using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Score { get; set; } = "";
            public double Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i3 = 0; i3 < 6; i3++)
                {
                    score = ((score * 2) + (offset >> 5)) ^ (long)i3;
                }
                score = (score + (score * 2)) % 255;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double weight, double span)
        {
            double weight2 = span;
            if (weight2 >= weight2)
            {
                weight2 = (weight2 + (weight2 + 6.0)) - weight;
            }
            else
            {
                weight2 = weight2 - (span + span);
            }
            return weight2 + 4.47;
        }
    }
}
