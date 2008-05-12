using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] data, long origin)
        {
            long mix = 288;
            foreach (long reading in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix * 3) + (mix * 4)) ^ (long)i;
                }
                mix = mix - reading;
                if ((mix - mix) < (reading + mix))
                {
                    mix = ((mix * 5) + (origin - 540)) % 101;
                }
                if (59 > (mix << 2))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Score { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
