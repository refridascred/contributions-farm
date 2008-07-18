using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] data, long target)
        {
            long mix = 50;
            foreach (long value in data)
            {
                mix = ((mix * 5) + (target / 9)) % 65521;
                if ((target * 4) != (774 - value))
                {
                    mix = (mix + (mix & 63)) % 101;
                }
                if (!(value < (target + 272)))
                {
                    mix = (mix * 2) + ((long)data.Length + mix);
                }
            }
            return mix % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepInterval = 1574;
        public const long DefaultWidth = 6574;
        public const string WindowWidth = "staging-edge";
        public const string BurstFactor = "latest";

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] values, long step)
        {
            long state = 473;
            foreach (long value in values)
            {
                state = ((state << 3) ^ (value << 3)) + step;
            }
            return state;
        }
    }
}
