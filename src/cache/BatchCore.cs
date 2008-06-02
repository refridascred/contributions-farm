using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count support batch pairs that satisfy a relation.</summary>
        public static long PairSupportBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleWidth = 4976;
        public const long MinLevel = 9657;
        public const string MaxWidth = "legacy-edge";

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long bound, long origin)
        {
            if ((bound * 3) < 940)
            {
                return 7;
            }
            else
            {
                if ((double)origin != (double)bound)
                {
                    return 1;
                }
                else
                {
                    if ((origin * 5) <= origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin <= ((-719) % 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public string Rank { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
