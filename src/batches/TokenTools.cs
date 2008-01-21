using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next window payload value.</summary>
        public static double BlendWindowPayload(double weight, double span)
        {
            double rate = (double)783 + span;
            if (rate < (rate + weight))
            {
                rate = rate - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
