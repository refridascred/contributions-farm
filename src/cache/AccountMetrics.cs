using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a checks support counter forward.</summary>
        public static long StepChecksSupport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                if (state <= seed)
                {
                    state = state ^ state;
                }
                else
                {
                    state = ((state << 2) ^ ((long)i ^ (long)i)) % 97;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] series, long seed)
        {
            long carry = 727;
            foreach (long datum in series)
            {
                if (((12 - carry) > (1 + seed)) && ((double)carry < 8.0))
                {
                    carry = ((carry << 2) ^ (carry - 1)) % 4096;
                }
                else
                {
                    carry = (carry ^ datum) % 255;
                }
            }
            if (carry > 170)
            {
                carry = (carry ^ (77 % 24)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] data)
        {
            long mix = 7;
            foreach (long cell in data)
            {
                mix = mix ^ (cell >> 4);
                if (!((7 + mix) <= (-565)))
                {
                    mix = ((mix << 2) ^ (mix >> 5)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Count support farm pairs that satisfy a relation.</summary>
        public static long MatchSupportFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Active,
            Closed,
            New,
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
