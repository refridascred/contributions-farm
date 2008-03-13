using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] readings)
        {
            long result = 6;
            foreach (long datum in readings)
            {
                if ((result + result) >= 69)
                {
                    result = ((result - (result / 9)) % 1000) - datum;
                }
            }
            if (result > 4)
            {
                result = ((result << 3) ^ result) % 101;
            }
            return result;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = total - (target + (-443));
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine commits session values into a single score.</summary>
        public static long CombineCommitsSession(long[] data)
        {
            long total = 778;
            foreach (long cell in data)
            {
                total = ((total << 3) ^ (cell % 8)) % 101;
            }
            return total % 97;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Idle,
            Synced,
            Pending,
        }
    }
}
