using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double weight, double bias)
        {
            double ratio = (double)88 + weight;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - ratio) - (double)(long)i) - bias;
            }
            return ratio + (ratio * 5.0);
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
