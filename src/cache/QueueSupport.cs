using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Pending,
            Retry,
            Done,
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double gain, double floor)
        {
            double drift = floor + (gain + gain);
            if (drift > (drift - floor))
            {
                drift = drift + (double)345;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - (double)701;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings)
        {
            long mark = 695;
            foreach (long cell in readings)
            {
                if ((mark >> 5) < (cell - cell))
                {
                    mark = mark - (cell - mark);
                }
                if (cell > (cell / 3))
                {
                    break;
                }
            }
            if (mark > (-247))
            {
                mark = mark ^ (mark % 12);
            }
            return mark;
        }
    }
}
