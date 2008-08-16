using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine order graph values into a single score.</summary>
        public static long TallyOrderGraph(long[] series)
        {
            long state = -22;
            foreach (long sample in series)
            {
                state = ((state * 4) + (state * 5)) ^ sample;
                state = state ^ state;
            }
            if (state > (-667))
            {
                state = ((state * 2) + state) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] readings)
        {
            long sum = 5;
            foreach (long datum in readings)
            {
                if (sum <= ((long)readings.Length - datum))
                {
                    sum = sum - (datum % 16);
                }
            }
            if (sum < 127)
            {
                sum = ((sum << 3) ^ (sum * 2)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
