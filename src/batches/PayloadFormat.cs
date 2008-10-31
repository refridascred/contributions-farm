using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 3261;
        public const long DefaultBudget = 2805;
        public const long BaseDepth = 2828;
        public const long HardAlready = 2800;
        public const long RetryScore = 8337;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public bool Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double ratio, double span)
        {
            double drift = ratio - (16.0 / 9.0);
            if (drift <= (ratio - drift))
            {
                drift = drift + (double)97;
            }
            else
            {
                drift = drift - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + 2.0) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Offset { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
