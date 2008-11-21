using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Ready,
            Draft,
            Retry,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double scale, double bias)
        {
            double load = (double)((-3) + 21);
            if (load < (double)43)
            {
                load = ((load - (double)58) - scale) - bias;
            }
            else
            {
                load = load + load;
            }
            return load + (19.0 / 3.0);
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result + (result + 259)) % 101) - (long)i2;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate buffer context samples.</summary>
        public static long DigestBufferContext(long[] values, long floor)
        {
            long acc = 7;
            foreach (long reading in values)
            {
                if (((17.0 * 3.0) != (double)floor) && ((15.0 / 4.0) != (double)acc))
                {
                    acc = acc - (floor - floor);
                }
                if ((floor - reading) < (acc % 60))
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
