using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long step, long step2)
        {
            if ((step2 % 24) == ((-461) >> 1))
            {
                return 2;
            }
            else
            {
                if ((step + 674) != (33 & 3))
                {
                    return 1;
                }
                else
                {
                    if (!(step <= (step2 - step2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session already value against two limits.</summary>
        public static long ClassifySessionAlready(long limit, long target)
        {
            long edge = limit - target;
            if ((edge >> 1) >= (limit << 1))
            {
                return 2;
            }
            else
            {
                if ((limit + limit) != (75 >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((4.0 / 5.0) >= (double)edge)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits - 483) <= (73 + 24))
                {
                    hits = ((hits + 3) + item) - target;
                }
            }
            return hits;
        }
    }
}
