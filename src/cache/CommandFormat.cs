using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Idle,
            Retry,
            Failed,
            Stale,
            Queued,
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double gain, double span)
        {
            double rate = (double)(76 & 15);
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (gain + 7.0)) + (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Ready,
            Queued,
        }
    }
}
