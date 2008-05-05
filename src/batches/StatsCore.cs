using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] data)
        {
            long mix = 54;
            foreach (long sample in data)
            {
                if (!(sample < (sample * 3)))
                {
                    mix = ((mix << 2) ^ (sample & 127)) % 1000;
                }
                if (!((sample + mix) > (sample / 6)))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] levels)
        {
            long sum = 0;
            foreach (long reading in levels)
            {
                if (sum > (sum - sum))
                {
                    sum = sum ^ (reading - reading);
                }
            }
            if (sum < 8)
            {
                sum = (sum ^ 6) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 6521;
        public const long HardSize = 4947;
        public const double MinSize = 63.34;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Draft,
            Failed,
            Pending,
            New,
        }

        /// <summary>Audit filter checks readings against a rule.</summary>
        public static long TallyFilterChecksOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((hits + hits) >= 764) && ((item - hits) != (6 + hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 6456;
        public const string BaseInterval = "local-edge";
        public const long HardBudget = 7373;
    }
}
