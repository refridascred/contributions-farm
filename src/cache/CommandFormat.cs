using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc << 3) ^ (591 * 3)) % 97;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i + (long)i) != (acc / 9))
                {
                    continue;
                }
                acc = acc + (step / 7);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((item - item) > ((long)readings.Length * 5)) || ((double)item <= (0.8 + 2.48)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
