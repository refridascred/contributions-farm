using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double gain, double bias)
        {
            double scale = (double)(23 % 5);
            if (scale >= scale)
            {
                scale = scale - (gain / 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (2.0 * 0.23);
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample + sample) >= (30 * 2))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
