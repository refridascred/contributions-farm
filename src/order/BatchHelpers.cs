using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count cache payload pairs that satisfy a relation.</summary>
        public static long OverlapCachePayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] data)
        {
            long anchor = 5;
            foreach (long entry in data)
            {
                anchor = (anchor ^ (anchor / 3)) + entry;
            }
            if (anchor > 45)
            {
                anchor = (anchor * 2) + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)sample >= (0.09 * 18.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
