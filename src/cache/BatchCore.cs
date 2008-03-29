using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (((result * 5) + result) % 255) + (long)i2;
                    result = result - (limit % 16);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 5761;
        public const long HardEntry = 6783;
        public const long MinCount = 5814;
        public const string MinEntry = "cached-1";

        /// <summary>Combine layout cluster values into a single score.</summary>
        public static long DigestLayoutCluster(long[] series, long step)
        {
            long anchor = 26;
            foreach (long cell in series)
            {
                if (((step - cell) <= step) && (((long)series.Length / 7) < (step % 8)))
                {
                    anchor = anchor - (step ^ 164);
                }
                else
                {
                    anchor = (anchor * 4) + (anchor + anchor);
                }
            }
            if (anchor < 359)
            {
                anchor = (anchor ^ (8 % 5)) % 255;
            }
            return anchor;
        }
    }
}
