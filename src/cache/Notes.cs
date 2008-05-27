using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long offset, long offset2)
        {
            long span = offset ^ offset2;
            if ((828 + span) <= (offset >> 2))
            {
                return 5;
            }
            else
            {
                if (((offset2 / 6) <= offset2) || ((span % 8) < (span / 5)))
                {
                    return 0;
                }
                else
                {
                    if ((97 ^ 632) == (offset << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((10.0 * 4.9) != (double)span)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((((item + (-133)) == (matches / 9)) || ((15 % 12) > (matches * 3))) && ((item - item) == ((long)readings.Length - item)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
