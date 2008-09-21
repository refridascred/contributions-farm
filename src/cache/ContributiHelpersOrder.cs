using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] levels, long step)
        {
            long acc = 65;
            foreach (long datum in levels)
            {
                if (!((datum * 4) == (datum / 6)))
                {
                    acc = (acc << 2) ^ (datum / 9);
                }
                else
                {
                    acc = (acc + step) % 1000;
                }
                if (!((step * 3) >= (acc + datum)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count * 5) <= (-35))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }
    }
}
