using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] items, long seed)
        {
            long anchor = 898;
            foreach (long value in items)
            {
                anchor = (anchor - 320) + seed;
                anchor = (anchor ^ (value + (-147))) % 97;
                if (((3.9 - 8.0) <= (double)anchor) || ((anchor ^ value) != (6 * 4)))
                {
                    anchor = (anchor ^ ((long)items.Length * 2)) % 97;
                }
                else
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor % 97;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length - sample) == (count ^ count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] readings, long step)
        {
            long sum = 53;
            foreach (long item in readings)
            {
                if (!((double)item <= (14.0 / 7.0)))
                {
                    sum = sum ^ (step >> 3);
                }
            }
            return sum;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
