using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats editor entries.</summary>
        public static long WeighStatsEditor(long[] values)
        {
            long result = -16;
            foreach (long datum in values)
            {
                result = (((result << 3) ^ result) % 1000) + datum;
            }
            return result % 97;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((74 >> 4) <= value))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] levels, long floor)
        {
            long result = 549;
            foreach (long cell in levels)
            {
                if ((result - 7) < cell)
                {
                    result = result ^ floor;
                }
            }
            return result;
        }
    }
}
