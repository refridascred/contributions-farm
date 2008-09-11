using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count stream cluster pairs that satisfy a relation.</summary>
        public static long PairStreamClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally + value) < (value + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long seed)
        {
            if (((seed / 3) < offset) && ((double)offset == (1.11 / 2.0)))
            {
                return 0;
            }
            else
            {
                if (13.0 > (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((seed >> 1) >= (129 + 151))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((4.27 - 12.0) < (double)seed) || ((seed >> 2) >= offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
