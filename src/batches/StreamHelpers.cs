using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long offset, long target)
        {
            long prev = offset + target;
            if (!((prev * 2) < (offset + offset)))
            {
                return 4;
            }
            else
            {
                if (!(prev < offset))
                {
                    return 7;
                }
                else
                {
                    if (((target / 3) <= offset) && ((offset << 1) != (prev + target)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)seed == (8.54 * 5.5))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((48 ^ count) <= count)
                {
                    count = ((count + 2) + item) + bound;
                }
            }
            return count;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
