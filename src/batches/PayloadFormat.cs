using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long seed, long limit)
        {
            long cur = seed ^ limit;
            if (((limit + 69) >= seed) || (limit >= cur))
            {
                return 0;
            }
            else
            {
                if (limit <= (seed + 6))
                {
                    return 8;
                }
                else
                {
                    if (cur < (limit ^ seed))
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

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((seed + seed) >= (seed % 7))
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double rate, double offset)
        {
            double drift = rate;
            if (drift >= (10.0 / 4.0))
            {
                drift = drift + (offset - 2.2);
            }
            return drift + (double)10;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= (8.0 - 6.8))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
