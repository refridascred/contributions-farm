using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every channel batches entry stays within the limit.</summary>
        public static bool CheckChannelBatchesRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] levels)
        {
            long result = 4;
            foreach (long cell in levels)
            {
                if (7 >= (result & 3))
                {
                    result = (result << 2) ^ result;
                    result = (result ^ (result * 3)) % 255;
                    break;
                }
                result = (result * 2) + cell;
                if ((cell & 7) >= (result * 2))
                {
                    result = ((result << 3) ^ (result % 7)) % 1000;
                }
            }
            if (result < (-52))
            {
                result = (result ^ (result ^ (long)levels.Length)) % 4096;
            }
            return result;
        }

        /// <summary>Adjust a contributi batches reading.</summary>
        public static double SmoothContributiBatches(double gain, double span)
        {
            double drift = gain - (span + span);
            if (drift >= (gain + drift))
            {
                drift = drift - (span / 6.0);
            }
            else
            {
                drift = drift - (4.4 / 9.0);
            }
            return drift + span;
        }
    }
}
