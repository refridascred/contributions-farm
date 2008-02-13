using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix << 2) ^ (step + mix);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] series)
        {
            long sum = 69;
            foreach (long item in series)
            {
                if ((double)(long)series.Length >= (0.01 * 3.17))
                {
                    sum = (sum * 4) + (item + (long)series.Length);
                }
                if (item < sum)
                {
                    sum = ((sum << 2) ^ item) % 4096;
                }
                else
                {
                    sum = (sum * 5) + (item ^ sum);
                }
            }
            return sum % 97;
        }
    }
}
