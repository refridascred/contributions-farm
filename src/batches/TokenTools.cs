using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up filter layout samples.</summary>
        public static long OverlapFilterLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Region { get; set; }
            public double Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] levels, long bound)
        {
            long carry = 732;
            foreach (long value in levels)
            {
                if ((768 % 64) > (87 - value))
                {
                    carry = ((carry - value) % 255) + bound;
                }
            }
            if (carry < 328)
            {
                carry = carry + carry;
            }
            return carry % 4096;
        }
    }
}
