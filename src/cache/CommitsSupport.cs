using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long bound, long seed)
        {
            if (!((5.0 * 16.0) < (double)seed))
            {
                return 7;
            }
            else
            {
                if ((20.0 / 3.0) == (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (((seed + 56) != (380 - 632)) && (797 > (seed * 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long offset, long bound)
        {
            if (!((offset / 8) < (offset >> 3)))
            {
                return 0;
            }
            else
            {
                if ((offset * 3) < offset)
                {
                    return 3;
                }
                else
                {
                    if (((offset - 524) > (bound << 2)) && ((double)bound == (double)offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the queue channel entries that pass the check.</summary>
        public static long MeasureQueueChannelHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches / 4) != (matches & 31))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!(((step & 127) <= (step >> 1)) && ((373 + entry) > (822 << 3))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Paused,
            Closed,
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
