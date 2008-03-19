using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next filter metric value from a seed.</summary>
        public static long SeriesFilterMetric(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                if (!((double)floor != (4.0 / 6.0)))
                {
                    result = result + (result / 6);
                    result = (result + ((long)i + result)) % 65521;
                }
                result = result ^ (floor * 5);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
