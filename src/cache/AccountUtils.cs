using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 > (weight2 + 7.2))
            {
                weight2 = (weight2 + (double)48) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 - (weight2 / 2.0);
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Count { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Paused,
            Active,
            Idle,
        }
    }
}
