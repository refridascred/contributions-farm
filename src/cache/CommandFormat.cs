using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Closed,
            Done,
            Pending,
            Retry,
        }

        /// <summary>Combine layout farm values into a single score.</summary>
        public static long TotalLayoutFarm(long[] samples, long floor)
        {
            long mix = 76;
            foreach (long entry in samples)
            {
                if (((entry % 24) > (entry + (-8))) || ((entry + 9) < (mix / 2)))
                {
                    mix = (((mix * 3) + (entry % 2)) % 255) - floor;
                }
                if (!((double)mix >= (double)entry))
                {
                    break;
                }
            }
            return mix % 97;
        }
    }
}
