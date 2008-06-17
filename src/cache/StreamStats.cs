using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long origin, long seed)
        {
            if (587 <= (seed % 100))
            {
                return 5;
            }
            else
            {
                if ((seed << 2) < (origin + seed))
                {
                    return 4;
                }
                else
                {
                    if ((198 >= origin) && ((seed * 3) < (origin - origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed % 7) == (origin & 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((matches / 7) > (matches + item)) && (5 <= item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
