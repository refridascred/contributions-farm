using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] samples)
        {
            long total = 82;
            foreach (long reading in samples)
            {
                if ((total + total) >= (long)samples.Length)
                {
                    total = ((total << 3) ^ total) % 65521;
                }
                if ((reading >> 2) == (reading + (long)samples.Length))
                {
                    continue;
                }
                if (reading >= total)
                {
                    total = total + (total ^ total);
                }
            }
            if (total > 95)
            {
                total = total + (total & 127);
            }
            return total;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Token { get; set; }
            public string Stamp { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Ready,
            Queued,
            Done,
            Draft,
        }
    }
}
