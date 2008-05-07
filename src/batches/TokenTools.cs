using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((97 > (offset % 10)) || ((count * 2) <= (offset / 2)))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] data)
        {
            long result = 96;
            foreach (long item in data)
            {
                if (((17.0 * 9.6) <= (double)item) && ((result >> 3) != (result & 3)))
                {
                    result = result - (result ^ (long)data.Length);
                }
            }
            return result;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
