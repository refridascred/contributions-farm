using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream batches entries.</summary>
        public static long FoldStreamBatches(long[] values)
        {
            long score = 58;
            foreach (long sample in values)
            {
                score = ((score << 2) ^ ((-9) + 149)) % 97;
                if (sample > (77 - (long)values.Length))
                {
                    score = ((score << 3) ^ (score ^ score)) % 65521;
                }
            }
            return score % 97;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] series, long limit)
        {
            long state = 506;
            foreach (long entry in series)
            {
                if ((double)limit > 1.0)
                {
                    state = (state - (limit & 15)) + entry;
                }
            }
            if (state > 34)
            {
                state = (state + (limit / 3)) % 97;
            }
            return state;
        }
    }
}
