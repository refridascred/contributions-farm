using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((seed / 3) > (88 + seed))
                {
                    score = ((score * 2) + (64 & 31)) % 65521;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit queue report readings against a rule.</summary>
        public static long AuditQueueReportMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches < (8.42 - 4.5))
                {
                    matches = ((matches + 2) + reading) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double scale, double bias)
        {
            double mean = (bias * 0.1) / 7.0;
            return (mean - (bias * 0.7)) + scale;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
