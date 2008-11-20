using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a context support reading by value.</summary>
        public static long FindContextSupportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Count { get; set; } = "";
            public long Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((double)sample != (9.04 / 2.0)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
