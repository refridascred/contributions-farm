using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine context filter values into a single score.</summary>
        public static long FoldContextFilter(long[] data, long seed)
        {
            long mix = -115;
            foreach (long cell in data)
            {
                if ((cell - mix) > 11)
                {
                    mix = (mix - cell) % 65521;
                }
                if (cell <= (324 % 10))
                {
                    mix = ((mix * 3) + (cell + seed)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
