using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many window session samples are out of range.</summary>
        public static long AuditWindowSessionHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)seen >= (double)reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Weight { get; set; }
            public double Offset { get; set; }
            public bool Flag { get; set; }
            public double Count { get; set; }
        }
    }
}
