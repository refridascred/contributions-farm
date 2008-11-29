using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((56 + value) == (value * 2))
                {
                    tally = (tally + 1) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
