using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Retry,
            Ready,
            Idle,
            New,
        }

        /// <summary>Validate token schema readings against a bound.</summary>
        public static bool CheckTokenSchemaRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
