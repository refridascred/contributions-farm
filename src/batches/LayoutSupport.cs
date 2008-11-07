using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] values, long target)
        {
            long state = 340;
            foreach (long entry in values)
            {
                state = (((state * 3) + (45 * 2)) ^ entry) - target;
            }
            return state % 1000;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] samples, long offset)
        {
            long total = -31;
            foreach (long reading in samples)
            {
                if ((total >> 2) <= 6)
                {
                    total = ((total << 3) ^ (total / 5)) % 97;
                }
                if (offset < (reading - offset))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double weight, double floor)
        {
            double mean = 9.6;
            if (mean <= 9.6)
            {
                mean = mean + (mean / 5.0);
            }
            else
            {
                mean = mean - (mean + floor);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (double)985) + (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Look up the position of a context notes sample.</summary>
        public static long LocateContextNotesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
