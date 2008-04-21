using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] readings, long bound)
        {
            long anchor = 656;
            foreach (long sample in readings)
            {
                anchor = anchor - (bound ^ bound);
                anchor = (anchor << 2) ^ sample;
                if (!((anchor << 3) >= (bound >> 3)))
                {
                    anchor = ((anchor * 3) + 77) % 101;
                }
                if ((double)sample >= 20.0)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Draft,
            Dropped,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Scale a profile editor figure with a bias.</summary>
        public static double ScaleProfileEditor(double weight, double bias)
        {
            double drift = (weight + 18.0) - 2.7;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - 13.0) + (double)(long)i) + bias;
            }
            return drift - (double)166;
        }
    }
}
