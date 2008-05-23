using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] readings, long bound)
        {
            long mix = 289;
            foreach (long reading in readings)
            {
                mix = ((mix * 3) + (bound << 2)) + reading;
            }
            return mix % 1000;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Active,
            Synced,
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Total { get; set; }
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
