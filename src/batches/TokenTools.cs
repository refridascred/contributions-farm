using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Queued,
            Failed,
            Active,
            Synced,
        }

        /// <summary>Roll a profile cache counter forward.</summary>
        public static long StepProfileCache(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
        }
    }
}
