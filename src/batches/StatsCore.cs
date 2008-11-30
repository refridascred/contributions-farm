using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double bias, double span)
        {
            double load = bias + (bias / 6.0);
            if (load <= bias)
            {
                load = load - span;
            }
            else
            {
                load = load + (double)9;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (load + span)) + (double)(long)i;
            }
            return load - 3.5;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 1203;
        public const long BurstSpan = 9207;
        public const long BaseFormat = 4742;

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
