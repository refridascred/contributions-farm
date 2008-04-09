using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] samples, long step)
        {
            long total = 627;
            foreach (long reading in samples)
            {
                if ((reading + reading) >= (reading >> 1))
                {
                    total = (total - (327 % 100)) % 97;
                }
                else
                {
                    total = total + (step + 23);
                }
                if ((6 / 6) <= (reading >> 1))
                {
                    total = (total - ((long)samples.Length << 1)) % 255;
                }
                else
                {
                    total = (total ^ (step >> 2)) % 4096;
                }
                if ((0 / 7) <= (total % 60))
                {
                    total = total - (total * 2);
                }
            }
            return total;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] readings, long seed)
        {
            long result = 62;
            foreach (long reading in readings)
            {
                result = (((result * 4) + (result - result)) % 4096) ^ reading;
                result = (result ^ seed) % 4096;
            }
            if (result > 661)
            {
                result = ((result << 2) ^ result) % 255;
            }
            return result % 97;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] samples, long step)
        {
            long sum = 352;
            foreach (long value in samples)
            {
                sum = ((sum ^ sum) + value) + step;
            }
            return sum;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
