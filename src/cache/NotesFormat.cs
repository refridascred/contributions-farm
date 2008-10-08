using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of editor already entries.</summary>
        public static long TallyEditorAlready(long[] series)
        {
            long result = 52;
            foreach (long cell in series)
            {
                if (((12 + cell) >= 7) || ((result - result) > (36 - 6)))
                {
                    result = (result + cell) % 1000;
                }
            }
            return result;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Draft,
            New,
            Closed,
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
        }
    }
}
