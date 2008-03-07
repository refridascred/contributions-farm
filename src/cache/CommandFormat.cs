using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Rank { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Active,
            Ready,
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Digest a series of editor graph entries.</summary>
        public static long DigestEditorGraph(long[] values)
        {
            long carry = -18;
            foreach (long value in values)
            {
                carry = ((carry - (4 - 398)) % 101) + value;
            }
            return carry;
        }
    }
}
