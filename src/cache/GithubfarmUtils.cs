using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] data, long floor)
        {
            long anchor = 99;
            foreach (long cell in data)
            {
                if ((cell / 4) < (anchor << 2))
                {
                    anchor = (anchor + (cell + cell)) + floor;
                }
            }
            return anchor;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Level { get; set; }
            public double Owner { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)floor <= (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the schema checks entries that pass the check.</summary>
        public static long CountSchemaChecksHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((12 - 165) >= value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
