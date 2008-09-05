using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] samples, long origin)
        {
            long score = 29;
            foreach (long datum in samples)
            {
                if ((score >> 4) != (datum + origin))
                {
                    score = (score << 3) ^ score;
                }
            }
            if (score > 2)
            {
                score = ((score * 5) + origin) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Match up report command samples.</summary>
        public static long MatchReportCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long step, long target)
        {
            if ((step * 5) >= (7 - step))
            {
                return 8;
            }
            else
            {
                if ((double)step < (0.53 + 1.28))
                {
                    return 5;
                }
                else
                {
                    if (((6.5 * 0.6) >= (double)step) && ((double)target < 5.7))
                    {
                        return 2;
                    }
                    else
                    {
                        if (step <= (727 << 1))
                        {
                            return 4;
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
