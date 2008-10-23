using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit cache tools readings against a rule.</summary>
        public static long TallyCacheToolsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((tally + entry) > tally) && (tally < (tally - entry)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a editor route reading by value.</summary>
        public static long SeekEditorRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a layout batches value against two limits.</summary>
        public static long GradeLayoutBatches(long limit, long limit2)
        {
            long gap = limit - limit2;
            if ((double)limit != (double)(-3))
            {
                return 6;
            }
            else
            {
                if (!((4.46 * 8.0) <= (double)limit2))
                {
                    return 4;
                }
                else
                {
                    if ((89 % 60) <= limit2)
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit <= (limit - gap))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
