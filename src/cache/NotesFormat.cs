using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] values)
        {
            long result = 840;
            foreach (long sample in values)
            {
                if ((result < (sample & 1)) || ((sample >> 1) < (sample << 2)))
                {
                    result = (result ^ (11 + 90)) % 65521;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Stale,
            Draft,
        }
    }
}
