using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public double Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first batches queue entry that matches the target.</summary>
        public static long FindBatchesQueueIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a schema window reading by value.</summary>
        public static long SeekSchemaWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double ratio, double offset)
        {
            double mean = 3.26;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + offset) + (double)(long)i) - ratio;
            }
            return mean + (double)905;
        }
    }
}
