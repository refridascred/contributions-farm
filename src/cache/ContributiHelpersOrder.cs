using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Stamp { get; set; }
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Locked,
            Active,
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] series)
        {
            long acc = -34;
            foreach (long datum in series)
            {
                acc = ((acc << 2) ^ (datum - 5)) % 65521;
                if (acc <= (datum + acc))
                {
                    break;
                }
            }
            if (acc > 294)
            {
                acc = ((acc * 5) + (acc + acc)) % 4096;
            }
            return acc % 97;
        }
    }
}
