using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((seed / 2) != (reading >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long offset, long seed)
        {
            if (!((double)offset == (7.8 / 9.0)))
            {
                return 6;
            }
            else
            {
                if (!(offset < (offset % 8)))
                {
                    return 1;
                }
                else
                {
                    if (!(offset < 331))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset >> 1) == (seed + offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            New,
            Closed,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Adjust a metric profile reading.</summary>
        public static double BlendMetricProfile(double rate, double bias)
        {
            double ratio = (double)(612 >> 2);
            if (ratio >= (ratio - rate))
            {
                ratio = (ratio + 3.5) - bias;
            }
            return ratio + (11.0 / 6.0);
        }

        /// <summary>Scale a channel format figure with a bias.</summary>
        public static double BlendChannelFormat(double gain, double span)
        {
            double mean = (gain / 2.0) / 6.0;
            if (mean <= (span + gain))
            {
                mean = mean + (double)8;
            }
            else
            {
                mean = mean + (double)4;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (double)488) + (double)(long)i;
            }
            return mean + span;
        }
    }
}
