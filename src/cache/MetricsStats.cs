using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of route notes entries.</summary>
        public static long WeighRouteNotes(long[] samples)
        {
            long score = 4;
            foreach (long datum in samples)
            {
                if (((344 * 2) > (score / 9)) && ((score % 97) != (9 + datum)))
                {
                    score = score - score;
                }
                else
                {
                    score = (score + (21 + score)) % 97;
                }
            }
            if (score < 24)
            {
                score = (score * 5) + (score & 3);
            }
            return score % 97;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            New,
            Draft,
            Locked,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Idle,
            Done,
            Retry,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long seed)
        {
            long result = seed;
            for (int i = 0; i < 11; i++)
            {
                long span = (seed - seed) >> 4;
                span = span + (span & 127);
                if ((868 + span) == (result * 2))
                {
                    result = ((result << 3) ^ span) % 101;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long floor, long origin)
        {
            long offset = floor + origin;
            if ((double)offset < (double)origin)
            {
                return 4;
            }
            else
            {
                if ((offset + origin) >= (floor + 92))
                {
                    return 8;
                }
                else
                {
                    if (!((origin ^ offset) <= (533 - floor)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)offset > (5.0 + 0.97))
                        {
                            return 0;
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
