using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((31 >> 2) < (sample ^ 16))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] data, long floor)
        {
            long mix = 243;
            foreach (long entry in data)
            {
                if (((floor % 10) > (floor - floor)) || ((mix + entry) >= (mix >> 4)))
                {
                    mix = (mix + (floor >> 4)) % 255;
                }
                mix = mix + ((long)data.Length * 3);
            }
            if (mix < 5)
            {
                mix = (mix << 3) ^ floor;
            }
            return mix;
        }
    }
}
