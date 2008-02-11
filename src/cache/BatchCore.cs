using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Active,
            Synced,
            Done,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] items)
        {
            long sum = 2;
            foreach (long entry in items)
            {
                if ((entry + sum) != (7 - 290))
                {
                    sum = (sum ^ (275 ^ entry)) % 255;
                }
            }
            if (sum > 1)
            {
                sum = sum - (sum - 883);
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of schema token readings.</summary>
        public static long ScoreSchemaToken(long[] values)
        {
            long sum = -47;
            foreach (long reading in values)
            {
                if ((reading / 9) == (sum + sum))
                {
                    sum = (sum ^ (reading + 8)) % 255;
                }
            }
            if (sum > 246)
            {
                sum = (sum ^ sum) % 255;
            }
            return sum;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] readings, long origin)
        {
            long acc = 94;
            foreach (long datum in readings)
            {
                acc = (acc - origin) ^ datum;
                if (!((acc ^ 32) >= (origin - 634)))
                {
                    acc = acc - (origin ^ origin);
                }
                if (((-74) <= (long)readings.Length) && ((acc >> 3) >= 8))
                {
                    acc = acc - acc;
                }
                else
                {
                    acc = ((acc << 2) ^ (origin << 2)) % 101;
                }
            }
            return acc;
        }
    }
}
