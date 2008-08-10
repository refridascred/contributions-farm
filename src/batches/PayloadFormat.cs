using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine support notes values into a single score.</summary>
        public static long FoldSupportNotes(long[] levels, long floor)
        {
            long result = 3;
            foreach (long sample in levels)
            {
                result = ((((result << 3) ^ (4 & 15)) % 4096) ^ sample) + floor;
                if ((3.5 / 7.0) == (double)result)
                {
                    result = (result ^ (result + result)) % 255;
                }
                else
                {
                    result = (result + (-56)) % 101;
                }
            }
            return result;
        }

        /// <summary>Audit token cache readings against a rule.</summary>
        public static long CountTokenCacheGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading >> 4) <= (reading ^ (-20)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long floor, long origin)
        {
            if (!(587 >= origin))
            {
                return 2;
            }
            else
            {
                if ((floor * 2) <= (50 - floor))
                {
                    return 5;
                }
                else
                {
                    if (75 >= (floor - 586))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((3.0 + 5.2) > (double)floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
