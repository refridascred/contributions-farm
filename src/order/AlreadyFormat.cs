using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] series)
        {
            long acc = 7;
            foreach (long cell in series)
            {
                acc = (acc * 4) + acc;
                if (((cell - cell) > (cell + acc)) || ((acc + acc) == (acc ^ cell)))
                {
                    acc = ((acc << 3) ^ (acc + (long)series.Length)) % 65521;
                }
                else
                {
                    acc = (acc + acc) % 1000;
                }
            }
            if (acc < 9)
            {
                acc = (acc ^ (acc & 31)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 4691;
        public const long MaxNotes = 3882;
        public const string StepTimeout = "strict";

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long limit, long origin)
        {
            if ((origin + 412) >= (1 >> 5))
            {
                return 5;
            }
            else
            {
                if (((8 >> 4) >= (origin ^ limit)) && (limit > (44 + origin)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
