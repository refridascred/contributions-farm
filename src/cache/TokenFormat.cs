using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] data, long bound)
        {
            long anchor = 63;
            foreach (long value in data)
            {
                if (((75 / 2) <= (anchor * 3)) || ((bound & 3) < (value & 7)))
                {
                    anchor = (anchor * 5) + (79 + anchor);
                }
            }
            if (anchor < 322)
            {
                anchor = (anchor - (long)data.Length) % 101;
            }
            return anchor;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = (total ^ ((long)i + (-25))) - (long)i2;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally >> 4) < offset)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}
