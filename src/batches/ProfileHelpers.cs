using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinBudget = 19.9;
        public const string BurstRatio = "stable-edge";
        public const double DefaultSpan = 56.59;
        public const string StepFilter = "strict-edge";

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Flag { get; set; }
            public bool Score { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Score { get; set; }
            public double Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Grade a already report value against two limits.</summary>
        public static long ClassifyAlreadyReport(long bound, long offset)
        {
            if (bound < (60 + bound))
            {
                return 5;
            }
            else
            {
                if ((bound - 29) != (bound + 1))
                {
                    return 0;
                }
                else
                {
                    if (((bound ^ 8) >= offset) || ((bound - offset) < (bound - bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + 4) != (offset << 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Active,
            Stale,
            Dropped,
            Locked,
            Done,
        }
    }
}
