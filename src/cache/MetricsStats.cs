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

        /// <summary>Match up layout metric samples.</summary>
        public static long OverlapLayoutMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] readings)
        {
            long score = 8;
            foreach (long value in readings)
            {
                score = score ^ (score * 2);
                if ((((-884) + score) != (value / 3)) && ((value + score) > (4 & 31)))
                {
                    score = (score * 5) + 3;
                }
                else
                {
                    score = score ^ (value + score);
                }
            }
            if (score > (-7))
            {
                score = score ^ (score + 514);
            }
            return score;
        }
    }
}
