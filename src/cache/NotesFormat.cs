using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine stream farm values into a single score.</summary>
        public static long DigestStreamFarm(long[] readings)
        {
            long sum = 359;
            foreach (long reading in readings)
            {
                if ((reading >= (sum + reading)) && ((sum + sum) < (sum >> 2)))
                {
                    sum = (sum * 4) + (reading ^ reading);
                }
                if (!((0.8 - 14.0) > (double)reading))
                {
                    break;
                }
            }
            if (sum < 23)
            {
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftRatio = 23.92;
        public const double CacheCount = 19.09;
        public const double BaseMetrics = 22.9;
    }
}
