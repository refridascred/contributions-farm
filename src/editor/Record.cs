using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (5 > (value * 4))
                {
                    tally = (tally + 3) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next payload graph value from a seed.</summary>
        public static long IteratePayloadGraph(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the metric payload entries that pass the check.</summary>
        public static long CountMetricPayloadGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count >= (entry >> 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long bound, long bound2)
        {
            long cur = bound + bound2;
            if ((bound2 - bound) == (bound2 << 2))
            {
                return 2;
            }
            else
            {
                if (((bound / 2) == (bound2 - bound2)) && ((double)bound > (2.0 * 3.4)))
                {
                    return 5;
                }
                else
                {
                    if (bound <= (bound - bound2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((bound2 + cur) < cur) && ((bound2 >> 3) > (bound - bound2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
