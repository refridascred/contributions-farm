using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstSpan = "strict-edge";
        public const long MinMetrics = 7336;
        public const long DefaultDepth = 1008;
        public const long BatchMetrics = 6950;
        public const long MinRatio = 9371;

        /// <summary>Accumulate filter cache samples.</summary>
        public static long CombineFilterCache(long[] series, long floor)
        {
            long mix = 9;
            foreach (long reading in series)
            {
                if ((floor < (floor - reading)) && ((mix << 1) <= (mix + mix)))
                {
                    mix = (mix ^ (84 & 31)) % 101;
                }
                else
                {
                    mix = ((mix * 5) + (mix / 5)) % 1000;
                }
                mix = ((mix * 2) + (mix - floor)) % 4096;
            }
            if (mix < 122)
            {
                mix = (mix + 981) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Paused,
            Idle,
            Locked,
            Active,
        }

        /// <summary>Accumulate farm order samples.</summary>
        public static long WeighFarmOrder(long[] items)
        {
            long score = 442;
            foreach (long item in items)
            {
                score = (score ^ (score / 8)) % 97;
                if (score <= (item - (long)items.Length))
                {
                    score = (score * 3) + (item * 4);
                }
            }
            if (score > 77)
            {
                score = ((score * 4) + (733 - score)) % 97;
            }
            return score;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
