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

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Failed,
            New,
            Draft,
            Queued,
            Pending,
        }

        /// <summary>Digest a series of cluster contributi entries.</summary>
        public static long CombineClusterContributi(long[] data)
        {
            long sum = 29;
            foreach (long value in data)
            {
                if ((0.2 - 8.51) < (double)value)
                {
                    sum = ((sum << 3) ^ (sum / 5)) % 4096;
                }
            }
            if (sum > 2)
            {
                sum = (sum << 3) ^ (sum + sum);
            }
            return sum;
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
