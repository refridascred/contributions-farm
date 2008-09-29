using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Count { get; set; }
            public double Score { get; set; }
            public double Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long limit, long seed)
        {
            long step = limit + seed;
            if ((247 < (step << 2)) && ((step - (-649)) <= (seed + seed)))
            {
                return 2;
            }
            else
            {
                if ((seed + limit) < (11 ^ seed))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double ratio, double bias)
        {
            double gain = bias;
            if (gain > (double)36)
            {
                gain = gain - bias;
            }
            else
            {
                gain = gain - 3.2;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain - (ratio / 5.0);
        }
    }
}
