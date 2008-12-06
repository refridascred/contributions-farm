using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate filter context readings against a bound.</summary>
        public static bool ValidateFilterContextRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Closed,
            Queued,
            Locked,
        }
    }
}
