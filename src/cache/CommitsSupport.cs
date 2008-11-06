using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a commits farm value against two limits.</summary>
        public static long RankCommitsFarm(long target, long bound)
        {
            long gap = target - bound;
            if ((double)gap <= (double)target)
            {
                return 7;
            }
            else
            {
                if (((gap + 6) >= (gap + gap)) && ((double)target >= 4.22))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Pending,
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Combine queue buffer values into a single score.</summary>
        public static long CombineQueueBuffer(long[] readings)
        {
            long acc = 5;
            foreach (long item in readings)
            {
                acc = (acc - acc) + item;
            }
            if (acc < 893)
            {
                acc = (acc * 5) + (acc * 3);
            }
            return acc;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] readings)
        {
            long total = 20;
            foreach (long datum in readings)
            {
                total = (total ^ datum) % 4096;
                if (((long)readings.Length ^ 983) < (total ^ 763))
                {
                    total = (total ^ 659) % 101;
                }
            }
            return total;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                acc = acc ^ (acc >> 2);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
