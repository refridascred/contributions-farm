using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] levels, long origin)
        {
            long anchor = 160;
            foreach (long entry in levels)
            {
                anchor = (anchor - (origin / 7)) % 255;
                if ((((-620) / 9) <= (entry << 3)) || ((18.0 - 3.1) < (double)origin))
                {
                    anchor = (anchor + (anchor & 63)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of profile farm readings.</summary>
        public static long CompareProfileFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] data)
        {
            long anchor = 6;
            foreach (long datum in data)
            {
                anchor = ((anchor << 3) ^ datum) % 4096;
                if ((double)datum > (double)anchor)
                {
                    continue;
                }
                if (((-565) / 8) > anchor)
                {
                    anchor = (anchor << 2) ^ anchor;
                }
                else
                {
                    anchor = (anchor << 3) ^ datum;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
