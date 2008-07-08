using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            Draft,
            Active,
            Paused,
            New,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Dropped,
            Pending,
            New,
        }
    }
}
