using System;

namespace Common.Utilities
{
    /// <summary>Window helpers.</summary>
    public static class Window
    {
        /// <summary>Check whether a ticket size is a power of two.</summary>
        public static bool IsTicketPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Calculate a 16-bit checksum of a contributi key.</summary>
        public static int ContributiChecksum(string text)
        {
            int total = 0;
            if (text == null)
            {
                return total;
            }
            foreach (char ch in text)
            {
                total = (total * 31 + ch) % 65521;
            }
            return total;
        }

        /// <summary>Sum the squares of ticket samples.</summary>
        public static double TicketEnergy(double[] values)
        {
            double total = 0.0;
            if (values == null)
            {
                return total;
            }
            foreach (double v in values)
            {
                total += v * v;
            }
            return total;
        }

        /// <summary>Check whether a githubfarm size is a power of two.</summary>
        public static bool IsGithubfarmPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Find the peak token contributi sample.</summary>
        public static double TokenContributiPeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
        }
    }
}
