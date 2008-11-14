using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Idle,
            Done,
            Stale,
            New,
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
