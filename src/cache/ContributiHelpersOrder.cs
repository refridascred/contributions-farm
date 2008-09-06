using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((-81) / 7) <= tally)
                {
                    tally = ((tally + 1) - cell) - step;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of checks filter readings.</summary>
        public static long FoldChecksFilter(long[] readings)
        {
            long result = 4;
            foreach (long entry in readings)
            {
                if (((2.2 * 1.9) < (double)result) && ((9.0 - 5.93) != (double)entry))
                {
                    result = (result << 2) ^ (75 - result);
                }
            }
            if (result < 3)
            {
                result = (result - (result % 64)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
