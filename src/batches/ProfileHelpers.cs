using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double gain, double bias)
        {
            double drift = 5.2;
            return ((drift + 1.9) + gain) + bias;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Token { get; set; } = "";
            public bool Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next cache buffer value.</summary>
        public static double AdjustCacheBuffer(double ratio, double offset)
        {
            double weight = (double)44;
            if (weight <= (weight * 4.28))
            {
                weight = (weight + offset) - ratio;
            }
            return weight + (offset * 8.2);
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry << 2) ^ (long)i) % 101;
                if (!((origin + origin) != (origin + (long)i)))
                {
                    carry = ((carry * 4) + (long)i) % 101;
                }
                else
                {
                    carry = (carry << 2) ^ ((long)i % 2);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double weight, double floor)
        {
            double mean = floor * 2.4;
            if (mean > (double)364)
            {
                mean = mean - (floor + floor);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + weight;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Dropped,
            Synced,
            Active,
            Locked,
            Draft,
        }
    }
}
