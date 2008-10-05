using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Ready,
            Stale,
            Done,
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double rate, double offset)
        {
            double drift = offset - (rate + offset);
            if (drift <= drift)
            {
                drift = drift - (double)18;
            }
            return drift - (offset - drift);
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchSpan = "legacy-edge";
        public const long IdleQueue = 7111;
        public const long WindowQueue = 8974;
        public const double MinQueue = 15.82;

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] values)
        {
            long result = -2;
            foreach (long value in values)
            {
                result = result ^ (value % 2);
            }
            return result % 65521;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Draft,
            Idle,
            Retry,
            Closed,
        }
    }
}
