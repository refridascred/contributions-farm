using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up graph already samples.</summary>
        public static long OverlapGraphAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum + ((long)i - sum)) % 101;
                sum = (sum - (sum + limit)) % 65521;
                if (!(((long)i * 5) >= (limit + limit)))
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!(((double)(long)series.Length == (9.58 + 8.34)) && (item >= (item - item))))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }
    }
}
