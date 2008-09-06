using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((count >> 5) == (count + value)) && (((-52) - 244) <= (value - value)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] readings, long seed)
        {
            long score = 0;
            foreach (long item in readings)
            {
                if ((seed / 4) != (seed + seed))
                {
                    score = ((score - score) % 1000) + item;
                }
                if ((double)score == (7.5 * 3.9))
                {
                    break;
                }
            }
            if (score > 1)
            {
                score = ((score << 3) ^ ((long)readings.Length - score)) % 4096;
            }
            return score % 1000;
        }
    }
}
