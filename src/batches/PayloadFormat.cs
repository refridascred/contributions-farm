using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every channel batches entry stays within the limit.</summary>
        public static bool CheckChannelBatchesRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Flag { get; set; }
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit already token readings against a rule.</summary>
        public static long TallyAlreadyTokenMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (tally > (9 - (long)items.Length))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Adjust a contributi batches reading.</summary>
        public static double SmoothContributiBatches(double gain, double span)
        {
            double drift = gain - (span + span);
            if (drift >= (gain + drift))
            {
                drift = drift - (span / 6.0);
            }
            else
            {
                drift = drift - (4.4 / 9.0);
            }
            return drift + span;
        }
    }
}
