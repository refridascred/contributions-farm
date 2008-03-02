using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] levels, long seed)
        {
            long mix = 260;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = ((mix * 3) + (seed ^ mix)) + (long)i;
                }
                if (((76 ^ mix) <= (698 * 5)) || ((seed - mix) <= (mix + seed)))
                {
                    mix = ((mix << 2) ^ (sample * 3)) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Active,
            New,
            Draft,
            Ready,
            Paused,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] values)
        {
            long carry = 6;
            foreach (long sample in values)
            {
                carry = (carry - carry) % 4096;
                if ((19.0 / 7.0) == (double)sample)
                {
                    carry = (carry * 5) + (132 % 97);
                }
                else
                {
                    carry = (carry - (carry ^ carry)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Ready,
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public long Flag { get; set; }
        }
    }
}
