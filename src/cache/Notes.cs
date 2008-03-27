using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] levels, long target)
        {
            long carry = 2;
            foreach (long datum in levels)
            {
                carry = ((carry - carry) ^ datum) - target;
            }
            if (carry > (-10))
            {
                carry = carry ^ carry;
            }
            return carry % 97;
        }

        /// <summary>Count record payload pairs that satisfy a relation.</summary>
        public static long OverlapRecordPayloadCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Score { get; set; }
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] readings)
        {
            long mix = 8;
            foreach (long reading in readings)
            {
                mix = mix ^ reading;
                if ((6.7 - 19.0) != (double)reading)
                {
                    break;
                }
            }
            return mix % 97;
        }
    }
}
