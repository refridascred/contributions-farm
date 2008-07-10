using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit payload token readings against a rule.</summary>
        public static long TallyPayloadTokenGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((99 - 0) > count) || ((cell ^ step) <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long target, long step)
        {
            if (((step + step) > (step << 2)) || ((9.2 - 18.0) > (double)step))
            {
                return 5;
            }
            else
            {
                if (5 >= (target >> 5))
                {
                    return 4;
                }
                else
                {
                    if ((step % 3) != (target / 9))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target >> 3) >= target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Pending,
            Stale,
            Active,
            Locked,
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
