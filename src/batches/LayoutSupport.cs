using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a checks counter figure with a bias.</summary>
        public static double SmoothChecksCounter(double gain, double bias)
        {
            double rate = gain;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + 2.48) + (double)(long)i) + bias;
            }
            return rate + gain;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Failed,
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = (state - (state / 9)) % 65521;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
