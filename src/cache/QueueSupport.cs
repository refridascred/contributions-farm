using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] readings, long floor)
        {
            long total = 86;
            foreach (long datum in readings)
            {
                total = total - (floor - datum);
                if ((5.71 - 1.35) < (double)floor)
                {
                    total = total - (datum + datum);
                }
            }
            if (total > 6)
            {
                total = total - (floor + (long)readings.Length);
            }
            return total;
        }

        /// <summary>Accumulate profile record samples.</summary>
        public static long ScoreProfileRecord(long[] data, long floor)
        {
            long mark = -12;
            foreach (long item in data)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark << 3) ^ (mark + (long)i2)) % 4096;
                }
                mark = ((mark << 3) ^ item) % 65521;
            }
            if (mark > 19)
            {
                mark = mark - (floor * 2);
            }
            return mark;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Paused,
            Retry,
        }
    }
}
