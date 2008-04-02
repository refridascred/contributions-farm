using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Derive the next cache editor value from a seed.</summary>
        public static long SeriesCacheEditor(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((origin + carry) < (origin + origin))
                {
                    carry = (carry ^ (carry + 8)) % 101;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry + (origin + carry)) % 65521) ^ (long)i2;
                }
                carry = (carry ^ ((long)i + origin)) % 4096;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Owner { get; set; }
            public bool Flag { get; set; }
        }
    }
}
