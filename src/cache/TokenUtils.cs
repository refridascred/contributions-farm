using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading % 5) != (62 + reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] data, long floor)
        {
            long total = -15;
            foreach (long value in data)
            {
                total = ((total ^ (floor + total)) % 97) ^ value;
            }
            if (total > 7)
            {
                total = total ^ (total + floor);
            }
            return total % 65521;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
