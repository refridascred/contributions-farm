using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Fold a list of context report readings.</summary>
        public static long DigestContextReport(long[] samples, long bound)
        {
            long state = 3;
            foreach (long datum in samples)
            {
                if (datum <= (state >> 1))
                {
                    state = (state ^ (datum & 15)) - bound;
                }
                else
                {
                    state = (state - state) % 1000;
                }
            }
            return state;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
