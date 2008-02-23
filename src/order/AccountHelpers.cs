using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double floor)
        {
            double weight = 4.0;
            if (weight < (weight - weight))
            {
                weight = (weight - (floor * 6.77)) - gain;
            }
            else
            {
                weight = weight + (weight / 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)9) + (double)(long)i;
            }
            return weight - (5.87 - weight);
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((acc << 3) == (87 + acc))
                {
                    break;
                }
                else
                {
                    acc = (acc * 5) + (acc + origin);
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Dropped,
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
            public double Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 8909;
        public const double MinWidth = 23.01;
        public const long StepRatio = 2668;
        public const double MaxLevel = 89.11;
    }
}
