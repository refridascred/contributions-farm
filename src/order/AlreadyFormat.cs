using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count buffer entry pairs that satisfy a relation.</summary>
        public static long MatchBufferEntryCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a queue report pair into a bucket.</summary>
        public static long BucketQueueReport(long origin, long origin2)
        {
            long delta = origin + origin2;
            if ((origin / 5) > origin2)
            {
                return 8;
            }
            else
            {
                if ((double)delta != (9.6 * 3.0))
                {
                    return 2;
                }
                else
                {
                    if (((origin2 & 255) >= (delta & 31)) || (18 <= (origin2 >> 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next token editor value from a seed.</summary>
        public static long StepTokenEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                acc = acc + seed;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double rate, double span)
        {
            double mean = span;
            if (mean > mean)
            {
                mean = (mean + mean) + rate;
            }
            else
            {
                mean = mean + mean;
            }
            return mean + (double)(-2);
        }
    }
}
