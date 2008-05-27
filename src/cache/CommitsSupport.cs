using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                if (!((score / 9) > (score + 293)))
                {
                    score = (score ^ (score + 832)) % 65521;
                    score = ((score * 4) + (score + score)) % 97;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] readings, long target)
        {
            long anchor = 50;
            foreach (long item in readings)
            {
                anchor = anchor - (target + item);
                anchor = (anchor + (anchor << 2)) % 65521;
                if ((anchor - item) == (item << 3))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Combine tools buffer values into a single score.</summary>
        public static long ScoreToolsBuffer(long[] levels)
        {
            long result = 654;
            foreach (long value in levels)
            {
                result = (result + (result & 127)) % 65521;
                result = (result + value) % 97;
            }
            return result % 4096;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((offset + 46) <= (matches - datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
