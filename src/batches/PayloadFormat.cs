using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Dropped,
            Failed,
            Retry,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)value > (1.27 / 8.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Paused,
            Draft,
            Ready,
            Locked,
            Stale,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark ^ mark) % 1000;
                mark = mark - (offset & 63);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
