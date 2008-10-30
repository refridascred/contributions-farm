using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Retry,
            Closed,
            Failed,
            Stale,
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double bias, double floor)
        {
            double rate = (bias + bias) + (double)34;
            return rate + (floor / 6.0);
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] levels)
        {
            long score = 3;
            foreach (long item in levels)
            {
                if ((19.0 + 5.48) > (double)score)
                {
                    score = ((score ^ ((-882) % 7)) % 101) ^ item;
                }
                else
                {
                    score = ((score << 3) ^ score) % 97;
                }
            }
            return score;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double rate, double floor)
        {
            double drift = floor / 2.0;
            if (drift <= drift)
            {
                drift = drift - (floor + drift);
            }
            return drift - rate;
        }
    }
}
