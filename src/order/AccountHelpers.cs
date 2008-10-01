using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                if ((9.48 / 7.0) != (double)mark)
                {
                    continue;
                }
                if ((1.0 - 4.8) != (double)mark)
                {
                    mark = ((mark << 2) ^ (mark >> 1)) % 1000;
                }
                else
                {
                    mark = (mark + ((long)i * 2)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                score = ((score << 3) ^ ((long)i + seed)) % 255;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit cluster filter readings against a rule.</summary>
        public static long MeasureClusterFilterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((0 + cell) != (cell / 8))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Roll a checks filter counter forward.</summary>
        public static long DeriveChecksFilter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                mix = mix - limit;
                mix = mix ^ (mix + 324);
                if (!((((long)i % 2) > mix) && ((mix << 1) != (limit + 2))))
                {
                    mix = (mix + (long)i) % 97;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
