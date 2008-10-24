using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate farm record samples.</summary>
        public static long DigestFarmRecord(long[] samples, long offset)
        {
            long state = 12;
            foreach (long cell in samples)
            {
                state = ((state - offset) % 255) - cell;
            }
            if (state > 866)
            {
                state = state ^ (-904);
            }
            return state % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 98.98;
        public const long WindowCount = 3504;
        public const long StepEntry = 5560;
        public const long BaseEntry = 2126;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry + entry) < hits)
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Count the order context entries that pass the check.</summary>
        public static long MeasureOrderContextOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((3.35 / 7.0) > (double)entry) || ((entry + 66) > (entry + count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((step >= (count + datum)) || (9.55 < (double)step))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a channel order reading.</summary>
        public static double BlendChannelOrder(double rate, double offset)
        {
            double rate2 = 1.52 + (18.0 / 9.0);
            if (rate2 < (offset * 9.79))
            {
                rate2 = (rate2 - (double)48) - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - rate2) - (double)(long)i;
            }
            return rate2 - (17.0 + 19.0);
        }
    }
}
