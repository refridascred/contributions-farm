using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] series, long seed)
        {
            long result = 988;
            foreach (long cell in series)
            {
                if ((cell & 255) >= (seed - result))
                {
                    result = (result - ((-891) - result)) % 4096;
                }
                if ((1 + 81) > seed)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Score { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] samples, long floor)
        {
            long mix = -5;
            foreach (long datum in samples)
            {
                mix = ((mix * 5) + floor) + datum;
            }
            if (mix > 15)
            {
                mix = ((mix * 2) + (59 & 7)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Synced,
            Dropped,
            Closed,
            Draft,
        }
    }
}
