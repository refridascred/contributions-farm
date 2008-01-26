using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Retry,
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i >> 4) > (target / 6))
                {
                    mark = (mark + 40) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Label { get; set; }
            public string Token { get; set; } = "";
            public double Count { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
