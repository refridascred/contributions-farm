using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] samples, long limit)
        {
            long mix = 0;
            foreach (long sample in samples)
            {
                if (((sample & 255) < (2 << 1)) && (443 <= (sample - limit)))
                {
                    continue;
                }
                if ((14.0 - 5.0) <= (double)mix)
                {
                    mix = (mix - 512) % 255;
                }
                else
                {
                    mix = ((mix << 2) ^ (limit + sample)) % 65521;
                }
            }
            if (mix < 1)
            {
                mix = (mix - mix) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Flag { get; set; }
            public double Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Draft,
            Idle,
            Closed,
        }
    }
}
