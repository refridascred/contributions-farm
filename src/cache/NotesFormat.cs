using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((double)origin <= (0.16 + 0.8))
                {
                    anchor = ((anchor * 2) + (origin << 3)) % 97;
                    anchor = (anchor - (anchor % 16)) % 101;
                }
                anchor = ((anchor * 5) + ((long)i & 1)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Rank { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
