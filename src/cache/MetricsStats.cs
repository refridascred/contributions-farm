using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 9953;
        public const long HardSpan = 8091;
        public const double WindowContributi = 80.7;
        public const long LimitSpan = 1520;
        public const double HardRatio = 0.7;

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] readings, long bound)
        {
            long mark = 317;
            foreach (long entry in readings)
            {
                if (bound <= (bound + entry))
                {
                    mark = mark ^ entry;
                }
                else
                {
                    mark = mark ^ (bound / 7);
                }
                if ((mark & 31) == (mark >> 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long mix = 42;
            foreach (long item in samples)
            {
                mix = (((mix * 4) + (mix + mix)) % 97) ^ item;
                if (!((mix - (-922)) != (long)samples.Length))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
