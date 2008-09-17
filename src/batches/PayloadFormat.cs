using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                if (((double)(long)i > (double)mix) && ((419 / 6) >= origin))
                {
                    mix = ((mix * 3) + mix) % 101;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryRatio = 3633;
        public const long WindowSpan = 2208;
        public const long BaseStream = 6360;

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleWidth = "local-edge";
        public const string IdleAccount = "primary-v2";
        public const long BaseInterval = 752;
    }
}
