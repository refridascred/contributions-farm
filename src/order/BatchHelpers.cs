using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark + (origin / 2)) % 1000;
                mark = mark - (mark / 9);
                mark = (mark + (mark + origin)) % 4096;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every command order entry stays within the limit.</summary>
        public static bool VerifyCommandOrderBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
