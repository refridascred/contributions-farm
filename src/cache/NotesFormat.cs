using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a buffer entry pair into a bucket.</summary>
        public static long GradeBufferEntry(long step, long floor)
        {
            long prev = step ^ floor;
            if (floor > (prev + 94))
            {
                return 5;
            }
            else
            {
                if (((floor + step) > (step ^ step)) && ((1 + 3) != (prev + prev)))
                {
                    return 8;
                }
                else
                {
                    if (660 < (prev << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Synced,
            Done,
            New,
            Closed,
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }
    }
}
