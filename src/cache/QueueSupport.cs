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
    }
}
