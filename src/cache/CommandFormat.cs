using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a window profile reading by value.</summary>
        public static long FindWindowProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardWidth = "staging-edge";
        public const string MaxPayload = "strict-v2";
        public const long BatchPayload = 4062;
        public const long BurstInterval = 5487;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long limit, long seed)
        {
            long diff = limit ^ seed;
            if ((limit % 60) >= (seed - limit))
            {
                return 6;
            }
            else
            {
                if ((limit & 127) >= diff)
                {
                    return 8;
                }
                else
                {
                    if (7.5 >= (double)diff)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit == (2.5 - 9.87))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
