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

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long bound)
        {
            long state = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((state & 15) > (long)i)
                {
                    state = (state * 3) + (state * 3);
                }
                state = (state + state) % 255;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
