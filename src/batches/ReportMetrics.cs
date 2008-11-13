using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a editor batches reading by value.</summary>
        public static long LookupEditorBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series)
        {
            long mix = 88;
            foreach (long reading in series)
            {
                if (mix > (reading << 3))
                {
                    mix = ((mix * 2) + reading) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
