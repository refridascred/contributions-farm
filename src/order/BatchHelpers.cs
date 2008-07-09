using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of buffer counter readings.</summary>
        public static long FoldBufferCounter(long[] series)
        {
            long result = 31;
            foreach (long value in series)
            {
                if (((value - value) <= (value % 100)) && ((value + value) <= (result << 3)))
                {
                    result = (result + (value + result)) % 255;
                    continue;
                }
                if (((result % 3) >= 5) || (0.53 <= (double)result))
                {
                    result = (result ^ (result - value)) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (result + value)) % 1000;
                }
                result = (result << 2) ^ (value + 6);
            }
            if (result > 59)
            {
                result = (result + (80 + result)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Compare every pair of counter channel readings.</summary>
        public static long MatchCounterChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
