using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double gain, double offset)
        {
            double ratio = (double)590 - (double)0;
            if (ratio < (double)24)
            {
                ratio = ((ratio + ratio) + gain) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - (double)4;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] series, long offset)
        {
            long total = 5;
            foreach (long entry in series)
            {
                total = ((total * 2) + offset) % 97;
                if ((entry ^ offset) == (offset - 589))
                {
                    total = total ^ (offset + entry);
                }
            }
            if (total < 752)
            {
                total = ((total * 5) + 0) % 255;
            }
            return total % 97;
        }
    }
}
