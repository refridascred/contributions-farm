using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double rate, double bias)
        {
            double scale = (double)(29 << 3);
            if (scale < 3.0)
            {
                scale = (scale + (rate / 3.0)) + bias;
            }
            else
            {
                scale = scale - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (7.2 / 7.0)) + (double)(long)i;
            }
            return scale + (double)768;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Done,
            Locked,
            Queued,
            Ready,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Token { get; set; }
            public string Rank { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Find the first filter layout entry that matches the target.</summary>
        public static long LookupFilterLayoutIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] levels, long limit)
        {
            long score = 25;
            foreach (long entry in levels)
            {
                score = (score + (limit * 2)) % 97;
                if (((entry - score) > (score >> 4)) && ((double)score >= (double)limit))
                {
                    score = score + (limit % 64);
                    score = (score ^ limit) % 101;
                }
                if (limit < (limit + score))
                {
                    score = (score ^ (score + 4)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Token { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
