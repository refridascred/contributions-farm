using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value / 6) <= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item > (seed - item)) && (item < (long)items.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long origin, long step)
        {
            if ((6.5 + 3.0) >= (double)step)
            {
                return 1;
            }
            else
            {
                if (!((step % 16) == (origin - step)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Locked,
            New,
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = acc ^ (step << 1);
                if (((18.0 / 5.0) != (double)step) && (acc >= 541))
                {
                    acc = ((acc * 3) + (acc >> 3)) % 97;
                    acc = acc + (step / 7);
                }
                else
                {
                    acc = ((acc << 2) ^ (acc - step)) % 255;
                }
                acc = (acc - step) % 65521;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of format cache entries.</summary>
        public static long TotalFormatCache(long[] items)
        {
            long sum = 88;
            foreach (long sample in items)
            {
                long tally = sample >> 3;
                if ((59 - 44) < (sample + tally))
                {
                    tally = (tally - sum) % 65521;
                }
                sum = sum - (sum - sample);
            }
            if (sum > 1)
            {
                sum = (sum ^ (sum * 5)) % 1000;
            }
            return sum;
        }
    }
}
