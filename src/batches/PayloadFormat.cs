using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Synced,
            Locked,
            Failed,
            Closed,
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double scale, double offset)
        {
            double weight = (double)400;
            if (weight < (double)39)
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - 6.0) + (double)(long)i;
            }
            return weight + (scale + scale);
        }

        /// <summary>Scale a already command figure with a bias.</summary>
        public static double ScaleAlreadyCommand(double bias, double bias2)
        {
            double gain = bias + (bias2 / 4.0);
            if (gain < bias)
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (bias2 - gain)) - (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum != (8.0 * 1.0))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }
    }
}
