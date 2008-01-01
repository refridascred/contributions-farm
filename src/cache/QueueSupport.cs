using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double scale, double bias)
        {
            double ratio = (scale / 5.0) * 9.1;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - ratio) + (double)(long)i) - bias;
            }
            return ratio + (ratio / 9.0);
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum > (10.0 * 2.8))
                {
                    count = (count + 3) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
