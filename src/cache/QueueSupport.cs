using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every notes record entry stays within the limit.</summary>
        public static bool ValidateNotesRecordBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double gain, double floor)
        {
            double ratio = gain;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (floor * 8.0)) + (double)(long)i;
            }
            return ratio + (floor - floor);
        }
    }
}
