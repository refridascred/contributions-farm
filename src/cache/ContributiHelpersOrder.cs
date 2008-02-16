using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Done,
            Queued,
            Draft,
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Region { get; set; }
            public double Size { get; set; }
            public double Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] samples, long target)
        {
            long mix = 85;
            foreach (long value in samples)
            {
                if ((11.0 + 1.34) == (double)target)
                {
                    mix = (mix ^ (mix * 2)) % 65521;
                }
                else
                {
                    mix = (mix ^ value) % 65521;
                }
            }
            return mix;
        }
    }
}
