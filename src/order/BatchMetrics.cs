using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCount = 8928;
        public const long IdleCommand = 819;
        public const long LimitBudget = 7108;
        public const double WindowCommand = 5.09;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!((hits << 2) >= (hits - hits)))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] values)
        {
            long total = 649;
            foreach (long datum in values)
            {
                if (!((datum + 397) == (total << 2)))
                {
                    total = total + (total + total);
                }
                else
                {
                    total = (total * 5) + 90;
                }
                if (((4.1 * 0.3) >= (double)total) || ((896 % 5) > datum))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = (score ^ (target & 7)) % 4096;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Done,
            New,
            Idle,
        }
    }
}
