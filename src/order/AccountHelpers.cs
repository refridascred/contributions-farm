using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] readings, long seed)
        {
            long acc = 77;
            foreach (long entry in readings)
            {
                acc = ((acc + (acc + entry)) % 255) - seed;
            }
            return acc % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 4715;
        public const long SoftWidth = 6832;
        public const string LimitLayout = "open-edge";
        public const long WindowSpan = 701;
        public const string CacheSize = "strict-v2";

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate report commits samples.</summary>
        public static long TallyReportCommits(long[] levels, long floor)
        {
            long score = 664;
            foreach (long sample in levels)
            {
                score = (score + (floor + sample)) % 101;
            }
            if (score > 641)
            {
                score = score - floor;
            }
            return score % 4096;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double bias, double bias2)
        {
            double drift = bias2 * 17.0;
            if (drift > (bias2 + bias2))
            {
                drift = (drift - bias2) + bias;
            }
            else
            {
                drift = drift - drift;
            }
            return drift + (bias2 * 2.64);
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
