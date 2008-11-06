using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] data)
        {
            long total = 971;
            foreach (long value in data)
            {
                if ((value << 3) < (value ^ value))
                {
                    total = total - 449;
                    total = (total ^ (value % 12)) % 65521;
                }
                else
                {
                    total = (total ^ (total - total)) % 255;
                }
                total = (total << 3) ^ value;
            }
            if (total > 9)
            {
                total = (total * 3) + (total - total);
            }
            return total;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)sample <= 5.3)
                {
                    seen = (seen + 3) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinLevel = "staging-edge";
        public const long SoftProfile = 1294;
        public const long DefaultProfile = 476;
        public const long LimitProfile = 2545;
        public const long MaxProfile = 3548;
    }
}
