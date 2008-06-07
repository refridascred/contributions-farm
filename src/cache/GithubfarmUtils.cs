using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double weight, double floor)
        {
            double load = 17.0;
            if (load < weight)
            {
                load = load + (load + floor);
            }
            else
            {
                load = load - (weight - 20.0);
            }
            return load - (double)18;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                result = (result + ((long)i >> 1)) % 97;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Failed,
            Active,
            Queued,
            Retry,
        }
    }
}
