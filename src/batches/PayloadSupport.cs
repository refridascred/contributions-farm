using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double gain, double span)
        {
            double load = (double)120;
            if (load >= (load * 0.1))
            {
                load = (load - span) + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                load = load + (double)(long)i;
            }
            return load - (double)667;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Label { get; set; } = "";
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Validate layout order readings against a bound.</summary>
        public static bool ValidateLayoutOrderLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
