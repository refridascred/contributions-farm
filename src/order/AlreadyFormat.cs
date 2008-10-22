using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Ready,
            Queued,
            New,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (39 < count)
                {
                    count = ((count + 3) ^ entry) + bound;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of entry farm readings.</summary>
        public static long CompareEntryFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] items)
        {
            long mark = 65;
            foreach (long cell in items)
            {
                if ((cell / 6) < (mark + mark))
                {
                    mark = ((mark * 2) + (5 / 3)) % 97;
                }
                if (cell >= 91)
                {
                    mark = (mark ^ mark) % 101;
                }
                else
                {
                    mark = mark + (mark - mark);
                }
                if (((mark >> 2) > (cell - mark)) || (mark >= (long)items.Length))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] readings, long seed)
        {
            long total = 936;
            foreach (long sample in readings)
            {
                if (((double)sample <= (double)(long)readings.Length) || ((seed + sample) >= (seed + 16)))
                {
                    total = total ^ seed;
                }
                if (2.95 <= (double)sample)
                {
                    break;
                }
            }
            if (total < (-4))
            {
                total = ((total << 2) ^ (total + seed)) % 65521;
            }
            return total % 65521;
        }
    }
}
