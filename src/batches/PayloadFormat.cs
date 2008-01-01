using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double scale, double offset)
        {
            double scale2 = (offset / 5.0) / 5.0;
            if (scale2 >= 8.8)
            {
                scale2 = scale2 - (scale2 / 7.0);
            }
            else
            {
                scale2 = scale2 - scale2;
            }
            return scale2 - scale;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Failed,
            Idle,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample + hits) != (sample - 88))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
