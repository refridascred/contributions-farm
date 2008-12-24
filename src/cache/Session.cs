using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Score { get; set; }
            public bool Total { get; set; }
            public string Size { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of order graph readings.</summary>
        public static long DigestOrderGraph(long[] values)
        {
            long mix = 912;
            foreach (long value in values)
            {
                mix = ((mix * 5) + (value / 6)) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double scale, double span)
        {
            double weight = span;
            return weight + (1.1 + scale);
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
