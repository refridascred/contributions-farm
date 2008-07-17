using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Active,
            Stale,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double bias, double span)
        {
            double load = span - (span / 2.0);
            if (load > bias)
            {
                load = load + load;
            }
            else
            {
                load = load + (load / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (load + 1.26)) + (double)(long)i;
            }
            return load + (load + 2.38);
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] series)
        {
            long result = 3;
            foreach (long cell in series)
            {
                result = (result + result) - cell;
                result = ((result * 5) + (7 % 10)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
