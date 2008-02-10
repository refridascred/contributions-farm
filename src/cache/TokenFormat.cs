using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long mix = 645;
            foreach (long sample in readings)
            {
                mix = ((mix * 2) + sample) % 4096;
                if ((((-32) + sample) != (sample ^ 81)) && (5.5 <= (double)sample))
                {
                    mix = (mix - 1) % 101;
                }
            }
            if (mix < (-19))
            {
                mix = (mix << 3) ^ (mix ^ mix);
            }
            return mix;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Pending,
            Idle,
            Synced,
        }
    }
}
