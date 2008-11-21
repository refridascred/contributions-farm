using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count order window pairs that satisfy a relation.</summary>
        public static long CompareOrderWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Retry,
            New,
            Synced,
            Queued,
        }
    }
}
