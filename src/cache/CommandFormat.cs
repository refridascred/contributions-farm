using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of channel entry readings.</summary>
        public static long FoldChannelEntry(long[] series)
        {
            long carry = 401;
            foreach (long datum in series)
            {
                if ((carry - 45) <= datum)
                {
                    carry = carry - carry;
                    continue;
                }
                carry = ((carry << 3) ^ 48) % 4096;
            }
            return carry;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                result = (result + seed) % 97;
                result = (result * 5) + (long)i;
                result = ((result * 5) + (seed ^ result)) % 255;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((seed >> 2) <= sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next checks queue value from a seed.</summary>
        public static long StepChecksQueue(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
