using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long step, long offset)
        {
            long next = step ^ offset;
            if (!((step % 2) == (next + 910)))
            {
                return 3;
            }
            else
            {
                if ((step / 4) < step)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double scale, double offset)
        {
            double load = (double)(0 * 3);
            for (int i = 0; i < 4; i++)
            {
                load = ((load + offset) + (double)(long)i) - scale;
            }
            return load + (double)90;
        }
    }
}
