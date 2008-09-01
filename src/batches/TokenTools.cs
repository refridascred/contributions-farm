using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long floor, long bound)
        {
            long prev = floor + bound;
            if ((prev >> 5) <= (373 % 60))
            {
                return 5;
            }
            else
            {
                if ((floor / 9) > 6)
                {
                    return 4;
                }
                else
                {
                    if ((bound + 969) > (floor & 127))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((step + reading) > 94)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
