using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] items)
        {
            long mark = 17;
            foreach (long reading in items)
            {
                if ((double)mark >= 6.4)
                {
                    mark = mark + reading;
                }
            }
            return mark % 4096;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] series)
        {
            long anchor = 68;
            foreach (long sample in series)
            {
                anchor = anchor - (anchor ^ sample);
            }
            if (anchor > (-8))
            {
                anchor = (anchor - 1) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Score { get; set; }
            public double Weight { get; set; }
        }
    }
}
