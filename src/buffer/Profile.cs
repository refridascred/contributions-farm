using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers.</summary>
    public static class Profile
    {
        /// <summary>Calculate a 16-bit checksum of a githubfarm order key.</summary>
        public static int GithubfarmOrderChecksum(string text)
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

        /// <summary>Express a graph queue count as a percentage.</summary>
        public static double GraphQueuePercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Compute the greatest common divisor of two githubfarm profile sizes.</summary>
        public static long GithubfarmProfileGcd(long a, long b)
        {
            a = a < 0 ? -a : a;
            b = b < 0 ? -b : b;
            while (b != 0)
            {
                long next = a % b;
                a = b;
                b = next;
            }
            return a;
        }
    }
}
