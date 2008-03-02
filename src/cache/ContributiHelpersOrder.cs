using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a record queue counter forward.</summary>
        public static long StepRecordQueue(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((offset + state) <= (state << 2))
                {
                    state = (state + ((long)i ^ (long)i)) % 255;
                    state = (state + (state ^ offset)) % 1000;
                    continue;
                }
                else
                {
                    state = (state * 5) + (state + (long)i);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] series, long step)
        {
            long mark = -3;
            foreach (long value in series)
            {
                mark = (mark + (step - step)) % 4096;
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark ^ (22 & 3)) % 255) ^ (long)i;
                }
                if ((value < (mark << 2)) || ((step - step) <= (mark - mark)))
                {
                    mark = (mark ^ (step * 3)) % 255;
                }
            }
            if (mark > 416)
            {
                mark = (mark + (mark >> 3)) % 101;
            }
            return mark % 1000;
        }
    }
}
