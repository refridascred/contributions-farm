using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = (score - (step - score)) % 255;
                score = score + (step + score);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((tally / 4) == (606 % 16)) || ((tally % 10) < datum))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 51.03;
        public const string IdleRoute = "legacy";
        public const string MinFactor = "local-1";
    }
}
