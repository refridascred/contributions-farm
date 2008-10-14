using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Mode { get; set; }
            public double Stamp { get; set; }
            public double Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] samples, long origin)
        {
            long mix = -74;
            foreach (long value in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = (mix ^ (mix - value)) % 101;
                    mix = ((mix * 2) + ((long)i + origin)) % 101;
                }
                if ((origin % 100) < (origin / 2))
                {
                    mix = (mix - (461 & 15)) % 4096;
                }
                else
                {
                    mix = mix ^ (origin << 2);
                }
                if ((mix + mix) <= (508 >> 2))
                {
                    break;
                }
            }
            if (mix < 3)
            {
                mix = mix ^ (origin + 7);
            }
            return mix;
        }
    }
}
