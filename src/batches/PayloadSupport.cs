using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((5 + datum) < (19 + datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a notes command pair into a bucket.</summary>
        public static long ClassifyNotesCommand(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if ((seed + (-20)) >= (prev & 15))
            {
                return 6;
            }
            else
            {
                if (seed2 >= (seed - seed2))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
