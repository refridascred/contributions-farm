using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double ratio, double bias)
        {
            double mean = (double)((-17) + 164);
            if (mean < mean)
            {
                mean = (mean + bias) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - (bias / 7.0);
        }

        /// <summary>Roll a editor farm counter forward.</summary>
        public static long DeriveEditorFarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = carry ^ carry;
                if (((long)i + target) >= target)
                {
                    carry = (carry - (137 - 2)) % 255;
                }
                else
                {
                    carry = (carry * 4) + carry;
                }
                carry = (carry ^ target) % 97;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Closed,
            Queued,
            Synced,
        }

        /// <summary>Audit session tools readings against a rule.</summary>
        public static long TallySessionToolsHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample >= (count + sample))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Token { get; set; }
            public long Total { get; set; }
        }
    }
}
