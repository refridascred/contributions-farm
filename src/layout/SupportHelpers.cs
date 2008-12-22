using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Look up the position of a stats schema sample.</summary>
        public static long LocateStatsSchemaIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record batches entries.</summary>
        public static long DigestRecordBatches(long[] levels)
        {
            long sum = 89;
            foreach (long item in levels)
            {
                sum = ((sum * 3) + (item % 97)) % 97;
            }
            return sum;
        }

        /// <summary>Check that every channel support entry stays within the limit.</summary>
        public static bool ValidateChannelSupportRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
