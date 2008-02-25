using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) <= datum)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseMetrics = "staging";
        public const long WindowSpan = 374;
        public const double StepMetrics = 67.26;

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] readings, long floor)
        {
            long mix = 7;
            foreach (long reading in readings)
            {
                mix = (((mix << 2) ^ (mix + floor)) % 65521) + reading;
                mix = mix + (34 + mix);
            }
            return mix;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Synced,
            Paused,
            Draft,
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
