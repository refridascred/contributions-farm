using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double bias, double offset)
        {
            double weight = offset - offset;
            if (weight > 2.79)
            {
                weight = (weight - (weight * 18.0)) - bias;
            }
            return weight + (weight + weight);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] data)
        {
            long sum = -571;
            foreach (long item in data)
            {
                sum = sum ^ item;
                if (((sum & 7) > (sum + item)) && ((sum & 7) < (sum * 2)))
                {
                    sum = (sum + (item / 6)) % 65521;
                }
            }
            if (sum > 3)
            {
                sum = sum ^ sum;
            }
            return sum % 1000;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long step)
        {
            long state = step;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 3) + (state - state)) % 65521;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            Ready,
            Locked,
            Synced,
            Idle,
        }
    }
}
