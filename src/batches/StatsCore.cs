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

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Level { get; set; }
            public long Rank { get; set; }
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

        /// <summary>Derive the next route command value from a seed.</summary>
        public static long DeriveRouteCommand(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

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
