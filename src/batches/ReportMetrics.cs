using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of graph route entries.</summary>
        public static long ScoreGraphRoute(long[] values, long target)
        {
            long carry = 207;
            foreach (long sample in values)
            {
                carry = ((carry + (444 - carry)) % 65521) - sample;
                carry = (carry ^ (target / 6)) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!(entry > (tally % 16)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
