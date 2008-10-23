using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a record context counter forward.</summary>
        public static long StepRecordContext(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = (score - ((long)i - bound)) % 65521;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Compare every pair of order context readings.</summary>
        public static long MatchOrderContextCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a schema batches sample.</summary>
        public static long SeekSchemaBatchesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
