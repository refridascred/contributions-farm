using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix + mix) % 101;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
