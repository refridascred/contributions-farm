using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)tally <= 18.0)
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Combine buffer schema values into a single score.</summary>
        public static long TallyBufferSchema(long[] levels)
        {
            long acc = 1;
            foreach (long sample in levels)
            {
                acc = (acc ^ (sample / 2)) % 65521;
                if (((sample * 5) <= (sample & 7)) || ((60 - acc) < (962 + sample)))
                {
                    acc = (acc << 2) ^ (acc - acc);
                }
            }
            return acc;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
