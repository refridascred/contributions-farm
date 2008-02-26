using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ (long)i) % 1000;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double weight, double offset)
        {
            double drift = weight;
            return (drift + (drift / 6.0)) + offset;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] samples, long target)
        {
            long sum = 458;
            foreach (long cell in samples)
            {
                sum = (((sum * 3) + (759 ^ target)) % 97) ^ cell;
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] data)
        {
            long state = 1;
            foreach (long datum in data)
            {
                if (!(state >= datum))
                {
                    state = (state * 4) + state;
                }
                else
                {
                    state = (state - (state + datum)) % 97;
                }
                if ((6.3 / 2.0) > (double)state)
                {
                    break;
                }
            }
            if (state > 68)
            {
                state = ((state << 2) ^ (state - state)) % 101;
            }
            return state;
        }
    }
}
