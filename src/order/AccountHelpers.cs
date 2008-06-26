using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                if ((double)mix >= (double)step)
                {
                    mix = ((mix << 3) ^ (step - mix)) % 4096;
                }
                if ((double)step > 0.62)
                {
                    mix = mix - (mix * 3);
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Count { get; set; }
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Failed,
            New,
            Pending,
            Paused,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
