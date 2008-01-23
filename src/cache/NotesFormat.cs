using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double ratio, double offset)
        {
            double rate = (double)863 / 5.0;
            if (rate < (double)4)
            {
                rate = (rate + (double)(-496)) + ratio;
            }
            return rate + offset;
        }
    }
}
