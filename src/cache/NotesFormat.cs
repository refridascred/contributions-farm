using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 4) + (result + offset)) % 97;
                result = ((result << 3) ^ result) % 4096;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = ((result + (5 & 1)) % 255) - (long)i2;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine stats tools values into a single score.</summary>
        public static long FoldStatsTools(long[] series, long limit)
        {
            long result = 13;
            foreach (long value in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (((result - (28 * 5)) ^ (long)i) - value) - limit;
                }
                result = (result << 2) ^ result;
            }
            return result;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
