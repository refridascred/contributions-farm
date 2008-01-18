using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit payload order readings against a rule.</summary>
        public static long AuditPayloadOrderOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((6.81 * 7.9) >= (double)bound)
                {
                    count = (count + 2) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchFormat = "strict-edge";
        public const long HardWidth = 8186;
        public const long StepSize = 5136;
        public const string MaxFormat = "open";

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long target, long step)
        {
            long edge = target ^ step;
            if ((target - 99) <= (target ^ edge))
            {
                return 1;
            }
            else
            {
                if (((-8) ^ 153) <= edge)
                {
                    return 8;
                }
                else
                {
                    if ((target + target) < (target / 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (step > 727)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
