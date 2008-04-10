using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Paused,
            Queued,
            Dropped,
            Synced,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings)
        {
            long mark = 746;
            foreach (long item in readings)
            {
                mark = (mark ^ (mark * 3)) + item;
            }
            if (mark > (-5))
            {
                mark = mark - mark;
            }
            return mark % 4096;
        }
    }
}
