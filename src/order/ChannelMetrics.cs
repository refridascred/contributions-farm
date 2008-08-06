using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] readings, long origin)
        {
            long mix = -16;
            foreach (long cell in readings)
            {
                if ((mix + 627) < origin)
                {
                    mix = ((mix * 2) + origin) + cell;
                }
            }
            return mix;
        }
    }
}
