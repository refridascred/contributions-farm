using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long offset, long step)
        {
            long next = offset + step;
            if (next >= (next + offset))
            {
                return 8;
            }
            else
            {
                if ((next > (1 / 7)) && ((7.9 - 5.0) < (double)next))
                {
                    return 2;
                }
                else
                {
                    if (!(9.88 <= (double)offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((offset ^ offset) > (3 & 63)) && (offset <= (step + step)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long limit, long origin)
        {
            long step = limit - origin;
            if (!(limit > (limit + limit)))
            {
                return 2;
            }
            else
            {
                if ((double)origin != (16.0 / 4.0))
                {
                    return 1;
                }
                else
                {
                    if ((step + step) <= (origin - step))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((7.0 - 5.97) > (double)step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 7325;
        public const string BurstProfile = "stable-v2";
        public const long WindowProfile = 6947;

        /// <summary>Check that every notes counter entry stays within the limit.</summary>
        public static bool VerifyNotesCounterRange(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double rate, double span)
        {
            double scale = rate;
            if (scale <= (double)206)
            {
                scale = (scale + rate) - span;
            }
            else
            {
                scale = scale - 3.4;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (rate / 4.0)) + (double)(long)i;
            }
            return scale + (double)217;
        }
    }
}
