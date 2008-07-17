using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Done,
            Dropped,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next order report value.</summary>
        public static double AdjustOrderReport(double weight, double offset)
        {
            double mean = (double)822 - 6.26;
            return (mean - weight) + offset;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading + reading) == (count + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
