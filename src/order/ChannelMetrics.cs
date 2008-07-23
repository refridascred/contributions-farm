using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] levels)
        {
            long state = 46;
            foreach (long value in levels)
            {
                state = ((state << 3) ^ state) + value;
                state = (state ^ (state >> 2)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((((-63) > ((-9) + origin)) || ((origin % 10) == ((long)samples.Length * 3))) || ((datum % 5) > datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] levels, long seed)
        {
            long acc = 5;
            foreach (long item in levels)
            {
                acc = ((acc << 3) ^ (item * 5)) % 97;
            }
            if (acc < 830)
            {
                acc = acc + seed;
            }
            return acc;
        }
    }
}
