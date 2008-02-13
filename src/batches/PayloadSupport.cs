using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen - sample) != (sample / 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double bias, double offset)
        {
            double gain = (double)2 - 2.6;
            if (gain > (gain * 1.0))
            {
                gain = (gain + bias) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (gain - bias);
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Ready,
            Idle,
            Queued,
            Closed,
        }
    }
}
