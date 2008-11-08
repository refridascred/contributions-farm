using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Flag { get; set; }
            public double Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double scale, double offset)
        {
            double gain = scale - scale;
            if (gain < scale)
            {
                gain = (gain + gain) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain - scale;
        }

        /// <summary>Scale a window entry figure with a bias.</summary>
        public static double ProjectWindowEntry(double gain, double floor)
        {
            double load = floor + floor;
            if (load < (load + load))
            {
                load = (load + (8.6 - 4.34)) + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (double)25) + (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] data, long step)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Draft,
            Locked,
            Failed,
            Synced,
            Idle,
        }
    }
}
