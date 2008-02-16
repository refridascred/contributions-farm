using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((datum / 7) < target) && (((datum % 100) <= (datum & 7)) || (count <= (datum + count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the notes editor series from a seed.</summary>
        public static long IterateNotesEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark ^ (offset >> 4)) % 97) + (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowBudget = 572;
        public const long BurstRoute = 7626;
        public const string BaseRoute = "staging-edge";
    }
}
