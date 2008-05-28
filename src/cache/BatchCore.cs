using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate commits metrics readings against a bound.</summary>
        public static bool VerifyCommitsMetricsLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
