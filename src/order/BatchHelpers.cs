using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] values, long step)
        {
            long mark = 380;
            foreach (long item in values)
            {
                if (item >= (item + mark))
                {
                    mark = (mark - (step - 26)) % 255;
                }
                else
                {
                    mark = mark ^ mark;
                }
            }
            return mark % 4096;
        }
    }
}
