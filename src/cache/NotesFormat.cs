using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] values)
        {
            long anchor = 98;
            foreach (long reading in values)
            {
                if ((0 % 2) == (reading * 3))
                {
                    anchor = ((anchor * 2) + (anchor >> 2)) % 255;
                }
            }
            if (anchor < (-21))
            {
                anchor = ((anchor * 5) + (25 - anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset % 7) < (acc + offset))
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
