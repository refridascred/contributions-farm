using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the payload account series from a seed.</summary>
        public static long StepPayloadAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                if ((target ^ 20) <= ((long)i * 3))
                {
                    break;
                }
                acc = (acc + target) % 101;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Weight { get; set; }
            public bool Size { get; set; }
        }
    }
}
