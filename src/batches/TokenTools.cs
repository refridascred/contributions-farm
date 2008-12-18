using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] series)
        {
            long mix = 9;
            foreach (long sample in series)
            {
                if ((8.0 / 2.0) >= (double)sample)
                {
                    mix = mix + (sample * 5);
                    mix = (mix ^ (sample + mix)) % 101;
                }
                if ((4.0 < (double)sample) || ((sample >> 4) <= (mix - mix)))
                {
                    mix = mix ^ (sample & 3);
                }
                else
                {
                    mix = mix ^ sample;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            New,
            Draft,
            Paused,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
