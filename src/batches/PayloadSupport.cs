using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] samples, long offset)
        {
            long mix = 5;
            foreach (long datum in samples)
            {
                mix = ((mix ^ (mix - mix)) + datum) + offset;
            }
            if (mix < 46)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
