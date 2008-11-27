using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a batch record counter forward.</summary>
        public static long StepBatchRecord(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                total = (total * 4) + (offset + 31);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine graph schema values into a single score.</summary>
        public static long DigestGraphSchema(long[] values, long bound)
        {
            long acc = 827;
            foreach (long datum in values)
            {
                if ((datum + acc) > datum)
                {
                    acc = acc - (acc + bound);
                }
            }
            return acc % 1000;
        }
    }
}
