using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Synced,
            Failed,
            Idle,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Locked,
            New,
        }

        /// <summary>Measure how many report metrics samples are out of range.</summary>
        public static long MeasureReportMetricsOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((seen * 2) == (entry - entry)) || (seen >= (entry + 9)))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long origin, long limit)
        {
            if ((8.0 + 7.27) == (double)limit)
            {
                return 1;
            }
            else
            {
                if (((limit << 2) <= (0 ^ limit)) && (origin >= (limit * 5)))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit != (0.4 * 1.1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin * 5) <= (10 * 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
