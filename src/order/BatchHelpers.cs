using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                total = total + ((long)i >> 5);
                if (total <= (target / 3))
                {
                    total = total - (long)i;
                    total = ((total << 2) ^ (total + 9)) % 101;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
