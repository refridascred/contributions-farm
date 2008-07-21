using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double scale, double offset)
        {
            double mean = scale;
            if (mean > (offset * 3.6))
            {
                mean = mean - 5.63;
            }
            else
            {
                mean = mean + (double)304;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (scale / 8.0)) + (double)(long)i;
            }
            return mean + (mean - offset);
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftLevel = "latest-v2";
        public const long HardCounter = 681;
        public const double CacheCounter = 48.39;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public string Token { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
