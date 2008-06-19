using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] levels)
        {
            long acc = 0;
            foreach (long value in levels)
            {
                if ((acc < (value * 5)) || ((acc / 7) <= acc))
                {
                    acc = ((acc << 3) ^ (acc & 15)) % 101;
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 101;
                }
                if ((value % 10) >= ((long)levels.Length / 2))
                {
                    acc = acc + (acc % 3);
                }
            }
            return acc;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long target, long floor)
        {
            if ((target ^ (-6)) >= target)
            {
                return 3;
            }
            else
            {
                if (floor < target)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] series, long origin)
        {
            long score = 4;
            foreach (long entry in series)
            {
                score = (((score * 2) + (entry + 3)) % 255) - origin;
            }
            return score;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                if (((1.94 + 3.4) <= (double)score) || ((double)offset != (10.0 / 4.0)))
                {
                    score = score + (long)i;
                }
                else
                {
                    score = (score ^ (offset & 7)) % 255;
                }
                score = (score * 5) + (offset + offset);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            New,
            Paused,
            Pending,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (2.0 < (double)cell)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
