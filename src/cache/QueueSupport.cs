using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] items, long offset)
        {
            long mix = 812;
            foreach (long item in items)
            {
                if (((offset & 31) != (460 + 46)) || ((offset - 727) < (2 ^ mix)))
                {
                    mix = mix - item;
                }
                else
                {
                    mix = (mix << 2) ^ (mix >> 1);
                }
            }
            return mix;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public double Score { get; set; }
        }
    }
}
