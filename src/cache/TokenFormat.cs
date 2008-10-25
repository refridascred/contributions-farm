using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Synced,
            New,
            Stale,
            Paused,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] data)
        {
            long acc = 82;
            foreach (long reading in data)
            {
                acc = (acc * 3) + (reading - reading);
                if (((687 + reading) > reading) && (reading > (66 ^ reading)))
                {
                    acc = (acc + (reading << 3)) % 101;
                }
                acc = ((acc * 4) + 60) % 65521;
                if (((acc - acc) <= ((long)data.Length - reading)) || ((reading ^ acc) < (acc - acc)))
                {
                    break;
                }
            }
            if (acc > 9)
            {
                acc = (acc << 2) ^ (acc >> 2);
            }
            return acc;
        }
    }
}
