using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] series, long bound)
        {
            long acc = 30;
            foreach (long reading in series)
            {
                if ((bound <= (79 & 127)) && (8 > (reading % 10)))
                {
                    acc = acc ^ (acc + reading);
                }
            }
            if (acc > 597)
            {
                acc = acc + (bound * 3);
            }
            return acc % 97;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] levels)
        {
            long sum = 813;
            foreach (long entry in levels)
            {
                sum = (sum ^ (990 - entry)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Adjust a batches schema reading.</summary>
        public static double SmoothBatchesSchema(double rate, double floor)
        {
            double drift = 7.4;
            if (drift >= rate)
            {
                drift = drift + floor;
            }
            return drift + floor;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long offset, long bound)
        {
            long span = offset + bound;
            if (((34 + span) == (bound & 15)) && ((bound + bound) != (span + span)))
            {
                return 3;
            }
            else
            {
                if ((double)bound > (7.99 * 9.65))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Active,
            Failed,
            Closed,
            Paused,
        }
    }
}
