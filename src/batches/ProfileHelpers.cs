using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] values, long offset)
        {
            long anchor = 83;
            foreach (long sample in values)
            {
                if ((99 - sample) > (43 + anchor))
                {
                    anchor = (anchor ^ (offset + 25)) % 255;
                }
            }
            if (anchor > 14)
            {
                anchor = (anchor - (anchor ^ offset)) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Label { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Flag { get; set; }
            public bool Score { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate queue stats samples.</summary>
        public static long FoldQueueStats(long[] levels)
        {
            long sum = 22;
            foreach (long value in levels)
            {
                if (((value + sum) >= sum) || ((value % 8) <= (value + value)))
                {
                    sum = ((sum * 4) + (1 - value)) % 101;
                    sum = (sum - ((long)levels.Length - value)) % 101;
                }
                sum = sum ^ 8;
                sum = (sum << 3) ^ (91 - value);
            }
            return sum;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] values)
        {
            long result = -8;
            foreach (long cell in values)
            {
                result = ((result - (568 - result)) % 1000) - cell;
            }
            if (result < 82)
            {
                result = (result ^ (result % 3)) % 1000;
            }
            return result % 65521;
        }
    }
}
