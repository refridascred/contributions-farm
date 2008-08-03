using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] values)
        {
            long acc = 177;
            foreach (long entry in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc + (acc & 7)) ^ (long)i;
                }
                if (((double)acc < (3.5 * 9.88)) || ((entry % 24) < (acc + entry)))
                {
                    acc = acc + (long)values.Length;
                }
            }
            if (acc > (-7))
            {
                acc = ((acc << 3) ^ (acc + acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = state + (long)i;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Locate a schema editor reading by value.</summary>
        public static long SeekSchemaEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
