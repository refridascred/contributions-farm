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

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                score = (score + (limit - 9)) % 97;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
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
