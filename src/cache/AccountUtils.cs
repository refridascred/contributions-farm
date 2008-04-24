using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Weight { get; set; } = "";
            public double Score { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] data)
        {
            long mix = 5;
            foreach (long sample in data)
            {
                if ((mix - 8) >= sample)
                {
                    mix = ((mix << 2) ^ (mix + mix)) % 1000;
                    break;
                }
                else
                {
                    mix = ((mix << 2) ^ 592) % 65521;
                }
                if ((mix + sample) > (mix - mix))
                {
                    mix = (mix + (sample >> 5)) % 101;
                }
            }
            if (mix > 43)
            {
                mix = ((mix * 4) + (mix + mix)) % 101;
            }
            return mix % 1000;
        }
    }
}
