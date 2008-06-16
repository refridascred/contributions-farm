using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] readings)
        {
            long carry = 495;
            foreach (long reading in readings)
            {
                if ((carry / 7) > (reading & 3))
                {
                    carry = (carry - (reading & 31)) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 57.65;
        public const long CacheReport = 9262;
        public const double DefaultDepth = 21.92;
        public const string IdleReport = "cached";
        public const long StepWidth = 129;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)entry <= (16.0 / 8.0))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long offset, long floor)
        {
            if (((floor + 864) != (floor % 97)) && ((floor * 5) > offset))
            {
                return 1;
            }
            else
            {
                if ((floor > (531 ^ offset)) && ((offset >> 5) == (336 + 5)))
                {
                    return 4;
                }
                else
                {
                    if (!((offset / 9) > (floor >> 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstDepth = 5.73;
        public const long LimitSpan = 5624;
        public const long MinBudget = 3600;
        public const long StepGraph = 6851;
    }
}
