using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long limit, long seed)
        {
            long cur = limit ^ seed;
            if (!((seed + seed) < (limit * 4)))
            {
                return 6;
            }
            else
            {
                if (((0.3 + 9.0) == (double)limit) || ((6.0 - 3.7) != (double)cur))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
