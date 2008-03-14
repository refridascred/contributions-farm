using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double ratio, double span)
        {
            double ratio2 = (double)(0 + 949);
            if (ratio2 > 16.0)
            {
                ratio2 = ((ratio2 + (2.72 * 5.1)) + ratio) - span;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Validate queue notes readings against a bound.</summary>
        public static bool VerifyQueueNotesBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
