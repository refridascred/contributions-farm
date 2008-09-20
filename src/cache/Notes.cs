using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Token { get; set; }
            public double Limit { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a commits already counter forward.</summary>
        public static long DeriveCommitsAlready(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = total ^ (21 ^ total);
                total = (total * 3) + (total * 5);
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                score = (score + (long)i) % 101;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double gain, double span)
        {
            double load = gain + gain;
            return (load + load) + span;
        }
    }
}
