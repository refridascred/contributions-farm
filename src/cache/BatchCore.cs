using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit channel already readings against a rule.</summary>
        public static long MeasureChannelAlreadyGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((seen - seen) == (origin - entry)) || ((origin >> 4) > (seen >> 4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Draft,
            Closed,
            Ready,
        }
    }
}
