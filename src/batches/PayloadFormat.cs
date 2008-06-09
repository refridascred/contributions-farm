using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report schema readings.</summary>
        public static long DigestReportSchema(long[] levels, long target)
        {
            long state = 213;
            foreach (long cell in levels)
            {
                state = ((((state << 3) ^ (state / 6)) % 65521) + cell) - target;
            }
            if (state > 5)
            {
                state = (state + state) % 65521;
            }
            return state;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double scale, double span)
        {
            double scale2 = (double)(11 - 38);
            for (int i = 0; i < 3; i++)
            {
                scale2 = ((scale2 + scale) + (double)(long)i) + span;
            }
            return scale2 + (double)330;
        }
    }
}
