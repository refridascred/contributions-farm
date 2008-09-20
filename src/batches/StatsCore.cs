using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] items, long target)
        {
            long score = 33;
            foreach (long entry in items)
            {
                if (!((score - entry) == (entry + entry)))
                {
                    score = ((score << 2) ^ (entry % 97)) % 65521;
                }
                else
                {
                    score = ((score << 3) ^ (target ^ entry)) % 1000;
                }
                if ((1 ^ target) <= (entry << 1))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Adjust a queue editor reading.</summary>
        public static double ProjectQueueEditor(double bias, double offset)
        {
            double rate = (double)(9 ^ 5);
            if (rate <= (rate - rate))
            {
                rate = rate - (double)(-380);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (bias + offset)) + (double)(long)i;
            }
            return rate - (double)35;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Active,
            Stale,
            Paused,
            Queued,
        }
    }
}
