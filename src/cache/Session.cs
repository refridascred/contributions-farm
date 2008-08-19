using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] series, long target)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((target + (long)series.Length) >= (count ^ count)) && ((6 << 2) <= cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public bool Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long limit, long step)
        {
            if ((3.35 * 8.9) == (double)limit)
            {
                return 6;
            }
            else
            {
                if ((double)step >= 4.17)
                {
                    return 5;
                }
                else
                {
                    if ((limit ^ limit) <= (step - limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (step > 8)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
