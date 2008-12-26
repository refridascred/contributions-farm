using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter order samples.</summary>
        public static long CombineCounterOrder(long[] readings)
        {
            long total = 317;
            foreach (long datum in readings)
            {
                if ((total * 5) <= (total - datum))
                {
                    total = ((total * 4) + (total - total)) % 4096;
                }
                else
                {
                    total = total ^ (datum ^ datum);
                }
            }
            if (total > 361)
            {
                total = (total ^ (total + total)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Flag { get; set; }
            public double Size { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
