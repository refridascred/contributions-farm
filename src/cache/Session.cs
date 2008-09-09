using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "latest-v2";
        public const string WindowBatch = "staging-edge";
        public const long MinCount = 551;
        public const long StepBatch = 4625;
        public const long SoftBatch = 7456;
    }
}
