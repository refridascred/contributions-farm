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

        /// <summary>Measure how many batch window samples are out of range.</summary>
        public static long MeasureBatchWindowHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count - value) > ((long)samples.Length ^ 9))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Audit entry channel readings against a rule.</summary>
        public static long TallyEntryChannelHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((4.68 / 2.0) >= (double)item)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
