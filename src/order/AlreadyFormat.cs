using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of cluster graph readings.</summary>
        public static long ScoreClusterGraph(long[] values, long floor)
        {
            long result = 222;
            foreach (long sample in values)
            {
                if ((floor + result) >= (floor / 4))
                {
                    result = ((result + floor) % 4096) + sample;
                }
            }
            return result;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((14.0 + 11.0) < (double)count)
                {
                    count = ((count + 3) + entry) - floor;
                }
            }
            return count;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long bound, long seed)
        {
            long delta = bound - seed;
            if (((44 * 4) >= seed) && ((double)seed != (7.46 * 17.0)))
            {
                return 5;
            }
            else
            {
                if (delta <= (delta & 255))
                {
                    return 0;
                }
                else
                {
                    if ((delta - seed) < (seed - seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound + 58) > bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 2757;
        public const long BaseAlready = 5811;
        public const long CacheWidth = 5779;
    }
}
