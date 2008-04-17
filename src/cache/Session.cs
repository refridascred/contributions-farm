using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a editor format figure with a bias.</summary>
        public static double BlendEditorFormat(double bias, double span)
        {
            double rate = span;
            if (rate <= (8.0 + rate))
            {
                rate = (rate - span) - bias;
            }
            return rate - span;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            Idle,
            Pending,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Level { get; set; }
            public long Size { get; set; }
        }
    }
}
