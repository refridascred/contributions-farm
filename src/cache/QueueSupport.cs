using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double bias, double span)
        {
            double ratio = bias;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (8.53 + bias)) + (double)(long)i;
            }
            return ratio + (span - ratio);
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] series)
        {
            long carry = 9;
            foreach (long cell in series)
            {
                if (((cell / 5) > 425) || ((double)cell >= 5.0))
                {
                    carry = (carry * 4) + (cell / 3);
                }
                if ((7.0 / 8.0) < (double)cell)
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
