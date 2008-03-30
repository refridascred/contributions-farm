using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits <= (hits % 7)) && (((70 << 2) >= (hits / 6)) && ((9.7 + 1.0) != (double)sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "legacy";
        public const string BaseMetric = "primary-v2";
        public const string HardScore = "legacy";
        public const long HardTimeout = 6474;
        public const long StepSize = 2471;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long floor)
        {
            if ((floor - floor) > 85)
            {
                return 5;
            }
            else
            {
                if (!((offset & 63) < floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)762 > (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((-637) ^ floor) == (89 ^ floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
