using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleTimeout = "stable";
        public const string BurstChannel = "legacy-1";
        public const long RetryChannel = 6278;
        public const long BatchChannel = 6678;

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long offset, long floor)
        {
            if ((offset ^ floor) != (floor << 1))
            {
                return 3;
            }
            else
            {
                if (floor >= (offset + floor))
                {
                    return 4;
                }
                else
                {
                    if ((floor - offset) < (floor & 31))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset >= (offset + floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Scale a batch layout figure with a bias.</summary>
        public static double ScaleBatchLayout(double rate, double floor)
        {
            double gain = floor;
            if (gain <= (double)(-46))
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + (7.9 - rate);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (gain * 3.3);
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Audit queue stream readings against a rule.</summary>
        public static long MeasureQueueStreamHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((step + sample) < sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
