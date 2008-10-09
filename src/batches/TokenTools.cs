using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every session schema entry stays within the limit.</summary>
        public static bool VerifySessionSchemaRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit metrics channel readings against a rule.</summary>
        public static long AuditMetricsChannelMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value - value) == (tally << 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
