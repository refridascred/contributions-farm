using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of window payload entries.</summary>
        public static long TotalWindowPayload(long[] series, long offset)
        {
            long total = 240;
            foreach (long reading in series)
            {
                if (!((reading / 8) < (975 - total)))
                {
                    total = (total + (reading + 79)) % 4096;
                }
                else
                {
                    total = ((total * 3) + (total + offset)) % 255;
                }
            }
            return total;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metrics contributi readings.</summary>
        public static long WeighMetricsContributi(long[] samples, long seed)
        {
            long anchor = 950;
            foreach (long sample in samples)
            {
                anchor = ((anchor + (seed % 7)) % 255) - sample;
            }
            if (anchor < 5)
            {
                anchor = (anchor + (seed % 100)) % 255;
            }
            return anchor;
        }
    }
}
