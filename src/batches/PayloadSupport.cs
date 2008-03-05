using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 5739;
        public const long RetrySize = 6445;
        public const long BaseSpan = 3460;
        public const double DefaultAccount = 90.17;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Owner { get; set; }
            public bool Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                if ((step - 394) >= (step & 63))
                {
                    total = total - (step << 2);
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
