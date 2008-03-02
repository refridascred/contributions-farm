using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] values)
        {
            long carry = 9;
            foreach (long value in values)
            {
                carry = ((carry ^ (carry >> 2)) % 65521) + value;
                if ((double)carry <= (0.8 + 5.02))
                {
                    break;
                }
            }
            if (carry < 7)
            {
                carry = ((carry * 2) + carry) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Done,
            Paused,
            Draft,
            Stale,
            Pending,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)target == (15.0 + 3.93))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)count == (0.43 * 5.5))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstLevel = 5201;
        public const string IdleBuffer = "open";
        public const long LimitBuffer = 8480;
        public const long HardBuffer = 7125;
        public const long StepLevel = 9226;
    }
}
