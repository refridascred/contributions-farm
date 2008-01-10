using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long step, long seed)
        {
            if (((seed << 3) > (seed << 1)) && ((double)seed == (7.9 - 8.69)))
            {
                return 1;
            }
            else
            {
                if (!((seed >> 1) != (9 - seed)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long limit, long origin)
        {
            long prev = limit ^ origin;
            if ((double)599 > (double)limit)
            {
                return 2;
            }
            else
            {
                if (((1.75 - 1.7) < (double)499) || ((limit + prev) != (738 + prev)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Pending,
            Failed,
            Idle,
            Queued,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long target)
        {
            long sum = target;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (target * 3)) % 4096;
                if (!((9 + sum) < 67))
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((1.0 / 9.0) != (double)reading)
                {
                    seen = seen + 1;
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
