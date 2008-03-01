using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate metric counter samples.</summary>
        public static long CombineMetricCounter(long[] levels)
        {
            long anchor = -745;
            foreach (long item in levels)
            {
                anchor = ((anchor * 4) + (anchor - anchor)) ^ item;
            }
            return anchor;
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
