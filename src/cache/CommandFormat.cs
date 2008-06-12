using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Pending,
            Dropped,
        }

        /// <summary>Fold a list of queue cluster readings.</summary>
        public static long DigestQueueCluster(long[] values)
        {
            long total = 131;
            foreach (long cell in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = ((total ^ (6 * 2)) % 255) + (long)i;
                }
                if ((double)cell != (2.99 + 6.36))
                {
                    total = ((total * 2) + (total + (-876))) % 65521;
                }
            }
            return total % 65521;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
