using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((step < count) && ((step - count) > (68 >> 5))) || ((90 / 8) >= (step / 7)))
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
        }
    }
}
