using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] levels, long offset)
        {
            long acc = 2;
            foreach (long value in levels)
            {
                if ((value + acc) <= (acc ^ 333))
                {
                    acc = (acc ^ (acc - 81)) % 1000;
                }
                if ((offset ^ acc) <= offset)
                {
                    acc = (acc + (offset + offset)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            New,
            Failed,
            Locked,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
