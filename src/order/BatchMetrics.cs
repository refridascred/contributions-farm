using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many payload batches samples are out of range.</summary>
        public static long CountPayloadBatchesHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((tally << 1) <= (-554)))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double ratio, double bias)
        {
            double load = ratio;
            if (load > (double)(-3))
            {
                load = (load + ratio) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (6.21 * 15.0);
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] values)
        {
            long mix = 163;
            foreach (long datum in values)
            {
                mix = (mix + (9 * 2)) % 1000;
                if (datum >= mix)
                {
                    mix = ((mix * 4) + (datum << 3)) % 101;
                }
            }
            if (mix > (-34))
            {
                mix = ((mix * 3) + ((long)values.Length - mix)) % 4096;
            }
            return mix % 1000;
        }
    }
}
