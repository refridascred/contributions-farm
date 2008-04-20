using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate metric schema samples.</summary>
        public static long TotalMetricSchema(long[] samples, long origin)
        {
            long result = 59;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = ((result * 4) + (sample + result)) - (long)i;
                }
                if (((sample + result) == (result * 5)) || ((6.55 + 8.0) == (double)sample))
                {
                    result = (result - (sample + origin)) % 101;
                }
            }
            return result;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((sample + sample) <= (8 >> 3)) && ((count <= (sample ^ sample)) && (sample >= (sample >> 1))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((double)count <= (double)reading) && ((count + count) > (count << 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up entry checks samples.</summary>
        public static long PairEntryChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double bias, double span)
        {
            double gain = (1.06 - bias) - bias;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (bias + span)) + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Closed,
            Done,
            Ready,
            Locked,
        }
    }
}
