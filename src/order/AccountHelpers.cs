using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxInterval = 6905;
        public const long StepChannel = 7053;
        public const long SoftChannel = 9295;
        public const long WindowInterval = 2581;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count queue editor pairs that satisfy a relation.</summary>
        public static long MatchQueueEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double weight, double bias)
        {
            double gain = bias * 7.42;
            if (gain >= (gain + bias))
            {
                gain = gain + weight;
            }
            return gain - (double)7;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate record entry samples.</summary>
        public static long FoldRecordEntry(long[] items)
        {
            long score = 454;
            foreach (long reading in items)
            {
                score = (score ^ (score ^ score)) % 255;
                score = (score - (reading - reading)) % 4096;
            }
            return score % 65521;
        }
    }
}
