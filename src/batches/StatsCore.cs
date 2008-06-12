using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit counter stats readings against a rule.</summary>
        public static long TallyCounterStatsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen - value) > (seen - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank payload farm input into a small class.</summary>
        public static long ClassifyPayloadFarm(long limit, long step)
        {
            long offset = limit ^ step;
            if ((double)step < (0.1 + 0.59))
            {
                return 5;
            }
            else
            {
                if ((limit * 5) != (limit & 127))
                {
                    return 1;
                }
                else
                {
                    if (((step << 2) > offset) && (step <= offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 8131;
        public const double WindowRatio = 22.99;
        public const double BurstCommits = 98.25;
        public const long WindowCommits = 9400;
        public const long HardCommits = 9950;

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long origin, long floor)
        {
            long edge = origin + floor;
            if ((edge % 5) == (edge + (-82)))
            {
                return 1;
            }
            else
            {
                if (((-5) + edge) >= (floor * 4))
                {
                    return 2;
                }
                else
                {
                    if (717 >= edge)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((origin + edge) != (origin * 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 4122;
        public const double StepContributi = 91.03;
        public const double MinCount = 6.44;
        public const double BatchSpan = 51.39;
        public const long HardTimeout = 844;
    }
}
