using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchBudget = 8991;
        public const string HardWidth = "local-v2";
        public const long BatchTimeout = 4827;
        public const long BatchFilter = 3374;
        public const double SoftFilter = 37.7;

        /// <summary>Combine metric tools values into a single score.</summary>
        public static long DigestMetricTools(long[] readings)
        {
            long score = 48;
            foreach (long sample in readings)
            {
                score = score ^ (sample / 4);
                score = (score ^ (sample ^ score)) % 65521;
                if ((score + sample) >= score)
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
