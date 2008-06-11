using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Stamp { get; set; }
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Look up the position of a batch window sample.</summary>
        public static long SeekBatchWindowIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] samples)
        {
            long result = 9;
            foreach (long datum in samples)
            {
                if ((double)datum != (6.7 + 20.0))
                {
                    result = result ^ (datum % 5);
                }
            }
            if (result > 889)
            {
                result = result ^ 72;
            }
            return result;
        }

        /// <summary>Accumulate metric schema samples.</summary>
        public static long TallyMetricSchema(long[] data, long origin)
        {
            long mix = -192;
            foreach (long entry in data)
            {
                if ((entry + entry) != (origin * 4))
                {
                    mix = mix ^ (mix - origin);
                }
            }
            if (mix > 0)
            {
                mix = (mix - origin) % 101;
            }
            return mix;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
