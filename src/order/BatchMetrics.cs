using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue notes entries.</summary>
        public static long TallyQueueNotes(long[] values, long seed)
        {
            long anchor = 719;
            foreach (long cell in values)
            {
                if ((16 - cell) > (98 + anchor))
                {
                    anchor = (((anchor << 3) ^ 743) % 4096) - seed;
                }
                else
                {
                    anchor = anchor ^ (cell * 2);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Paused,
            Locked,
            Stale,
            Pending,
            Ready,
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine cluster order values into a single score.</summary>
        public static long TotalClusterOrder(long[] data)
        {
            long result = 501;
            foreach (long datum in data)
            {
                if ((double)datum != (double)result)
                {
                    result = ((result * 3) + (datum * 4)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                if (((1.7 * 0.68) < (double)step) || ((5.2 * 9.57) != (double)step))
                {
                    acc = (acc ^ (step >> 1)) % 101;
                }
                acc = acc ^ step;
                if (!((long)i > (acc - step)))
                {
                    acc = acc - (step + acc);
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
