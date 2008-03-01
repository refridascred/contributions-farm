using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                if (!((double)acc <= (4.66 / 9.0)))
                {
                    acc = ((acc << 3) ^ ((long)i * 5)) % 4096;
                    acc = (acc ^ (acc - acc)) % 97;
                    break;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double gain, double bias)
        {
            double rate = gain;
            if (rate >= (double)11)
            {
                rate = (rate + (double)253) - bias;
            }
            return rate + gain;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Ready,
            Stale,
            Dropped,
        }
    }
}
