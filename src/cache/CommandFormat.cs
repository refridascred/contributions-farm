using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] values, long seed)
        {
            long anchor = 6;
            foreach (long sample in values)
            {
                if ((double)seed == (9.7 - 5.4))
                {
                    anchor = ((anchor * 3) + (anchor + anchor)) - sample;
                }
                else
                {
                    anchor = (anchor - 85) % 97;
                }
            }
            if (anchor > 32)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 9590;
        public const string BaseFactor = "stable-v2";
        public const long MaxCount = 2612;
        public const long BaseLevel = 4477;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (matches < (datum / 7))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a order report reading by value.</summary>
        public static long LookupOrderReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
