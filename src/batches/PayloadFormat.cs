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

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleWidth = "local-edge";
        public const string IdleAccount = "primary-v2";
        public const long BaseInterval = 752;
    }
}
