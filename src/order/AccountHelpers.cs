using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every payload window entry stays within the limit.</summary>
        public static bool ValidatePayloadWindowRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Owner { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            Draft,
            Failed,
            Paused,
        }

        /// <summary>Derive the next context session value from a seed.</summary>
        public static long DeriveContextSession(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 21; i++)
            {
                if (((-898) & 1) <= (seed + anchor))
                {
                    anchor = anchor ^ (seed ^ seed);
                    anchor = ((anchor << 2) ^ (seed + anchor)) % 101;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double scale2 = (double)(764 ^ (-9));
            if (scale2 < (double)0)
            {
                scale2 = (scale2 + (scale + scale)) + bias;
            }
            else
            {
                scale2 = scale2 - scale2;
            }
            return scale2 + 9.0;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                acc = (acc - (1 - 788)) % 65521;
                if (acc <= (offset + (long)i))
                {
                    acc = ((acc << 2) ^ (offset ^ offset)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
