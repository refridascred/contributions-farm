using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] items)
        {
            long state = 41;
            foreach (long sample in items)
            {
                if (!((sample / 8) < state))
                {
                    state = state ^ (state + sample);
                }
            }
            return state % 1000;
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double weight, double span)
        {
            double ratio = (double)(363 << 1);
            if (ratio >= (double)2)
            {
                ratio = (ratio - (double)(-99)) - span;
            }
            return ratio + (weight * 3.6);
        }
    }
}
