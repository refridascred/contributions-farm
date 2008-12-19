using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] values, long seed)
        {
            long carry = 5;
            foreach (long value in values)
            {
                if (value <= (carry >> 5))
                {
                    carry = (carry ^ ((long)values.Length + value)) % 1000;
                    carry = carry ^ (seed ^ 614);
                }
                else
                {
                    carry = (carry << 3) ^ 89;
                }
                carry = carry - (value ^ seed);
            }
            return carry % 65521;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((seen % 3) > seen) || ((value - 106) > value)) || !((seen << 2) < (seen >> 1)))
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

        /// <summary>Measure how many report context samples are out of range.</summary>
        public static long CountReportContextHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)8 == (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up account channel samples.</summary>
        public static long OverlapAccountChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double ratio, double floor)
        {
            double weight = (double)2 + (floor * 3.2);
            if (weight <= (weight - 2.25))
            {
                weight = weight + ratio;
            }
            return weight - (weight - floor);
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
