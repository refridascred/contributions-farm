using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Roll a command editor counter forward.</summary>
        public static long IterateCommandEditor(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                double scale = (double)origin / 3.0;
                if (anchor <= origin)
                {
                    scale = scale - (scale + scale);
                }
                if ((scale / 9.0) >= (scale - scale))
                {
                    anchor = anchor - anchor;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            Queued,
            Ready,
            Done,
        }
    }
}
