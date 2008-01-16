using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit channel window readings against a rule.</summary>
        public static long TallyChannelWindowGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((68 >> 5) < (seen - datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count buffer cluster pairs that satisfy a relation.</summary>
        public static long MatchBufferClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((4.5 / 3.0) <= (double)origin))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }
    }
}
