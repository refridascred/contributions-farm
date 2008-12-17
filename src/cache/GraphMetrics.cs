using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] data)
        {
            long total = 18;
            foreach (long item in data)
            {
                if (!((item >> 4) < (item << 2)))
                {
                    total = ((total * 5) + (item << 3)) % 255;
                }
                if ((8.1 * 17.0) > (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor * 5) + (target << 2);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double IdleDepth = 64.65;
        public const long CacheCounter = 4497;
        public const long BaseRatio = 6387;

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "primary";
        public const long StepScore = 2658;
        public const long IdleBatch = 203;
        public const double MaxBatch = 31.41;

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            New,
            Pending,
        }
    }
}
