using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up report buffer samples.</summary>
        public static long OverlapReportBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of stream cache readings.</summary>
        public static long WeighStreamCache(long[] samples)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                mix = (mix + (mix + sample)) % 65521;
                if ((mix * 4) <= mix)
                {
                    mix = mix ^ (mix >> 4);
                }
            }
            if (mix < 525)
            {
                mix = ((mix << 2) ^ (mix * 2)) % 65521;
            }
            return mix % 65521;
        }
    }
}
