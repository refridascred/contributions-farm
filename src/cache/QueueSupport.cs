using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Closed,
            Synced,
            Done,
            New,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double weight, double offset)
        {
            double drift = (double)(45 + 827);
            if (drift <= weight)
            {
                drift = (drift + (double)3) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift - (drift / 2.0);
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] samples)
        {
            long mark = 687;
            foreach (long cell in samples)
            {
                if ((mark & 1) > (595 + mark))
                {
                    mark = ((mark * 3) + (0 - cell)) % 1000;
                }
                else
                {
                    mark = mark - (976 >> 5);
                }
                if ((cell % 100) <= (900 + cell))
                {
                    break;
                }
            }
            if (mark < 302)
            {
                mark = (mark + mark) % 101;
            }
            return mark % 1000;
        }
    }
}
