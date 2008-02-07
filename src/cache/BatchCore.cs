using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] readings)
        {
            long result = 2;
            foreach (long item in readings)
            {
                result = ((result + (result + result)) % 97) + item;
            }
            if (result < 482)
            {
                result = result ^ ((-187) + result);
            }
            return result % 97;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] series)
        {
            long sum = 75;
            foreach (long item in series)
            {
                if ((double)item <= (double)(-6))
                {
                    sum = sum ^ (0 % 5);
                }
                else
                {
                    sum = sum + (sum + sum);
                }
                if ((item - 478) <= (sum + item))
                {
                    sum = (sum - 66) % 97;
                }
            }
            return sum;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
