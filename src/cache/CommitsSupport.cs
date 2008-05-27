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

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public double Weight { get; set; }
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

        /// <summary>Combine already batches values into a single score.</summary>
        public static long TotalAlreadyBatches(long[] series)
        {
            long anchor = 85;
            foreach (long sample in series)
            {
                anchor = anchor + ((long)series.Length - sample);
            }
            return anchor;
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
