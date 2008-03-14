using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] data)
        {
            long total = 878;
            foreach (long entry in data)
            {
                total = (total + total) % 97;
                total = (total - (entry & 127)) % 1000;
            }
            return total;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Fold a list of metric command readings.</summary>
        public static long DigestMetricCommand(long[] samples, long step)
        {
            long mix = 230;
            foreach (long value in samples)
            {
                if (value >= (1 + value))
                {
                    mix = (mix - (step + value)) % 4096;
                }
            }
            if (mix > 72)
            {
                mix = mix + (mix - mix);
            }
            return mix;
        }

        /// <summary>Check that every support profile entry stays within the limit.</summary>
        public static bool ValidateSupportProfileBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
