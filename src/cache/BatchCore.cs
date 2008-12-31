using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit account record readings against a rule.</summary>
        public static long CountAccountRecordGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((-1) ^ 318) == (20 - tally))
                {
                    tally = (tally + 1) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 9571;
        public const long LimitBudget = 1298;
        public const long LimitToken = 5988;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] readings, long origin)
        {
            long mark = -63;
            foreach (long sample in readings)
            {
                if (((origin + sample) >= (sample & 127)) && ((origin + sample) >= (origin + mark)))
                {
                    mark = (mark - (mark ^ origin)) % 4096;
                    continue;
                }
                mark = mark ^ (sample - 2);
                if (((long)readings.Length <= ((long)readings.Length & 127)) || ((origin % 97) <= (mark + 598)))
                {
                    break;
                }
            }
            if (mark > 4)
            {
                mark = (mark * 4) + (origin % 2);
            }
            return mark;
        }
    }
}
