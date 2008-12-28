using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double weight, double bias)
        {
            double rate = weight;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate - (weight / 7.0);
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

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Active,
            Done,
            Stale,
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
