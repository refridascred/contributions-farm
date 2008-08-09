using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the filter account series from a seed.</summary>
        public static long RollFilterAccount(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                mark = mark - (1 & 31);
                mark = (mark - ((long)i / 9)) % 65521;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Roll a schema order counter forward.</summary>
        public static long IterateSchemaOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((origin ^ origin) <= (long)i)
                {
                    mix = (mix ^ (mix ^ mix)) % 4096;
                }
                mix = (mix + (origin / 6)) % 97;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
