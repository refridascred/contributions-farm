using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Audit format tools readings against a rule.</summary>
        public static long TallyFormatToolsOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell * 2) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((seed + carry) >= carry)
                {
                    carry = ((carry << 3) ^ (carry & 63)) % 255;
                    continue;
                }
                carry = (carry + seed) % 65521;
                if ((double)seed > (2.15 - 1.0))
                {
                    carry = ((carry << 3) ^ (seed - carry)) % 255;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
