using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Ready,
            Pending,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long floor, long origin)
        {
            if (255 <= (floor % 12))
            {
                return 5;
            }
            else
            {
                if ((origin << 3) != (floor << 2))
                {
                    return 1;
                }
                else
                {
                    if (origin < (origin >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many format already samples are out of range.</summary>
        public static long AuditFormatAlreadyOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (floor >= (floor ^ reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)target <= 16.0)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Project the next context support value.</summary>
        public static double AdjustContextSupport(double ratio, double bias)
        {
            double gain = bias;
            if (gain >= (double)45)
            {
                gain = gain + ratio;
            }
            return gain + (double)32;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
