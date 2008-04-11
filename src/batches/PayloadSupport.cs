using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Roll a command account counter forward.</summary>
        public static long IterateCommandAccount(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((offset >> 1) > (result % 60))
                {
                    break;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
