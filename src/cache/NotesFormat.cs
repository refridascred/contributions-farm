using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] values, long origin)
        {
            long mix = -74;
            foreach (long item in values)
            {
                if ((3.0 * 4.62) <= (double)mix)
                {
                    mix = (((mix << 3) ^ (origin & 7)) % 255) + item;
                }
            }
            return mix;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Flag { get; set; }
            public bool Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
