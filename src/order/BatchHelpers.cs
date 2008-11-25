using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of session queue entries.</summary>
        public static long ScoreSessionQueue(long[] readings, long target)
        {
            long total = 2;
            foreach (long reading in readings)
            {
                if (((2 + 52) < (total & 255)) && (reading >= (target - 85)))
                {
                    total = ((total * 3) + (total - reading)) % 1000;
                }
                else
                {
                    total = total ^ reading;
                }
            }
            if (total < 53)
            {
                total = (total - (target & 31)) % 65521;
            }
            return total;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (limit / 9)) % 65521;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Paused,
            Retry,
            New,
            Stale,
            Active,
        }
    }
}
