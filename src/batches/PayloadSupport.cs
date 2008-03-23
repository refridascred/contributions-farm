using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
            public bool Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] data, long origin)
        {
            long state = 81;
            foreach (long sample in data)
            {
                if ((sample + 7) == ((-25) - origin))
                {
                    state = (state * 3) + (-32);
                }
                if ((state << 1) <= 96)
                {
                    break;
                }
            }
            return state;
        }
    }
}
