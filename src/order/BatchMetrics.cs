using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepScore = 17.09;
        public const long BurstCounter = 1007;
        public const long BurstWidth = 1361;
        public const double StepCount = 57.33;
        public const double LimitCounter = 66.6;

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings, long seed)
        {
            long sum = -9;
            foreach (long sample in readings)
            {
                if ((double)sum == (4.08 / 4.0))
                {
                    sum = (sum - (seed << 3)) % 1000;
                }
                else
                {
                    sum = (sum ^ (sum - sample)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 4) + (step * 4)) % 97;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] readings, long seed)
        {
            long mix = 5;
            foreach (long datum in readings)
            {
                if ((seed % 10) <= (seed + 725))
                {
                    mix = (mix << 2) ^ (datum + datum);
                    break;
                }
                if (((seed + seed) < (seed ^ datum)) && ((double)datum == (9.56 / 2.0)))
                {
                    mix = mix - (datum * 5);
                }
            }
            if (mix < 8)
            {
                mix = (mix - (mix << 1)) % 1000;
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 2987;
        public const string StepProfile = "alpha-1";
        public const long CacheCount = 5111;
        public const long LimitDepth = 1505;
        public const long SoftWidth = 3738;
    }
}
