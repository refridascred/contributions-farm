using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Queued,
            Done,
            Draft,
            Closed,
            Ready,
        }

        /// <summary>Rank schema entry input into a small class.</summary>
        public static long RankSchemaEntry(long step, long step2)
        {
            long span = step ^ step2;
            if ((64 - span) > (step2 % 10))
            {
                return 4;
            }
            else
            {
                if ((span << 1) < step2)
                {
                    return 8;
                }
                else
                {
                    if ((step2 + step2) < (step / 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((span % 2) < step2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long seed, long step)
        {
            long cur = seed - step;
            if ((cur & 255) <= (cur - cur))
            {
                return 8;
            }
            else
            {
                if (seed >= (step / 4))
                {
                    return 6;
                }
                else
                {
                    if ((cur / 9) > cur)
                    {
                        return 1;
                    }
                    else
                    {
                        if (cur >= (step + 433))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double rate, double floor)
        {
            double gain = rate;
            if (gain > (2.14 - rate))
            {
                gain = gain + gain;
            }
            return gain - floor;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((4 * 5) > entry)
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }
    }
}
