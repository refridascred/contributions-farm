using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two githubfarm order measurements.</summary>
        public static double ScaleGithubfarmOrder(double gain, double bias)
        {
            double scale = (double)896 - (gain + gain);
            if (scale <= bias)
            {
                scale = scale - (double)52;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (scale - scale);
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value & 7) >= count)
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Level { get; set; }
            public long Total { get; set; }
        }
    }
}
