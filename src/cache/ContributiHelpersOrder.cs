using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] readings)
        {
            long result = 579;
            foreach (long sample in readings)
            {
                if ((result ^ sample) <= sample)
                {
                    result = (result * 5) + (58 ^ sample);
                }
            }
            return result;
        }
    }
}
