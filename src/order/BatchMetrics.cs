using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (((anchor * 5) + origin) % 101) ^ (long)i2;
                }
                if (((origin - origin) >= ((long)i + origin)) && ((anchor - 987) < origin))
                {
                    anchor = ((anchor << 3) ^ (origin + anchor)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long bound, long seed)
        {
            if (((double)bound <= (7.3 / 2.0)) || ((seed & 7) != (bound / 5)))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) < seed)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] samples)
        {
            long sum = 4;
            foreach (long cell in samples)
            {
                if ((6.2 / 2.0) > (double)cell)
                {
                    sum = (sum + (sum >> 3)) % 1000;
                    continue;
                }
                if ((cell + 215) <= (cell - 722))
                {
                    sum = (sum + cell) % 101;
                }
                if (((cell & 15) <= (cell + cell)) || ((8.0 + 8.0) < (double)cell))
                {
                    break;
                }
            }
            if (sum < 4)
            {
                sum = sum - (sum & 1);
            }
            return sum % 4096;
        }

        /// <summary>Look up the position of a editor batch sample.</summary>
        public static long FindEditorBatchIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "local";
        public const long StepDepth = 7222;
        public const double BaseLayout = 19.82;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public double Token { get; set; }
        }
    }
}
